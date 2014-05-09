package model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Random;

/**
 * Individual object which simulates each skiier's values and past experience
 * @author
 *
 */
public class Individual implements Serializable, Runnable {

	private static final long serialVersionUID = 1L;
	/**
	 * Name of Individual
	 */
	public int ID;
	/**
	 * Lists of all the current individual's friend
	 */
	public ArrayList<int[]> friends;
	/**
	 * Lists of the individual's past and current skill level
	 */
	public ArrayList<Double> skill;
	/**
	 * Lists of the past simulation's weather
	 */
	public ArrayList<Double> weather;
	/**
	 * Individual's IQ level
	 */
	public int IQ;
	/**
	 * Lists of the past and current decision percent
	 */
	public ArrayList<Double> decisionPercent;
	/**
	 * Lists of the individual's past and current experience
	 */
	public ArrayList<Double> experience;
	/**
	 * Lists of history if the individual went to the resort
	 */
	public ArrayList<boolean[]> went;
	/**
	 * Lists of individual's past success rate
	 */
	public ArrayList<boolean[]> success;
	/**
	 * Lists of the individual's success percent (sum(success)/num_of_iterations)
	 */
	public ArrayList<Double> successpercent;
	/**
	 * Lists of the individual's went percent (sum(went)/num_of_iterations)
	 */
	public ArrayList<Double> wentpercent;
	
	/**
	 * Constructor for Individual
	 * @param ID: Name of Individual
	 * @param numskiiers: Number of skiiers currently on resort
	 * @param numweeks: Number of week of the simulation
	 * @param wmean: average weather input
	 * @param fmean: average number of friends
	 * @param smean: average skills
	 * @param dp: Decision percent of the simulation
	 * @param exp: Current individual's experience
	 */
	public Individual(int ID, int numskiiers, int numweeks, double wmean, double fmean, double smean, double dp, double exp){
		Random r = new Random();
		IQ = (int) (r.nextDouble()*3 + 1);
		friends = new ArrayList<int[]>();
		skill = new ArrayList<Double>();
		weather = new ArrayList<Double>();
		decisionPercent = new ArrayList<Double>();
		experience = new ArrayList<Double>();
		successpercent = new ArrayList<Double>();
		wentpercent = new ArrayList<Double>();
		went = new ArrayList<boolean[]>();
		success = new ArrayList<boolean[]>();
		this.ID = ID;
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		
	}
	
	/**
	 * Adds the parameter values to the respective lists
	 * @param r: Random generator
	 * @param numskiiers: Number of skiiers currently on resort
	 * @param numweeks: Number of week of the simulation
	 * @param wmean: average weather input
	 * @param fmean: average number of friends
	 * @param smean: average skills
	 * @param dp: Decision percent of the simulation
	 * @param exp: Experience Percent of the individual
	 */
	public void setvalues(Random r, int numskiiers, int numweeks, double wmean, double fmean, double smean, double dp, double exp){
		int numfriends;
		
		
		double rand = r.nextGaussian();
		double w = 2;
		while(w > 1 || w < 0){
			rand = r.nextGaussian();
			w = wmean + (r.nextBoolean() ? rand : rand*-1)/4;
		}
		weather.add(w);
		
		numfriends = (int) (fmean + r.nextGaussian()*3 + 1);
		while(numfriends > 8 || numfriends < 1){
			rand = r.nextGaussian();
			numfriends = (int) (fmean + (r.nextBoolean() ? rand : rand*-1)*2 + 1);
		}
		
		double s = -1;
		while(s < 0 || s > 1){
			rand = r.nextGaussian();
			s = (smean + (r.nextBoolean() ? rand : rand*-1)*.3);
		}
		skill.add(s);
		
		double exper = exp + r.nextGaussian()*.1; 
		while(exper < 0 || exper > 1)
			exper = exp + r.nextGaussian()*.25; 
		experience.add(exper);
		
		
		int[] array = new int[numfriends];
		for(int i = 0; i < numfriends; i++){
			int newfriend = (int) (r.nextDouble()*numskiiers);
			boolean boo = true;
			for(int j = 0; j < i; j++){
				if(array[j] == newfriend){
					boo = false;
				}
			}
			if(boo)
				array[i] = newfriend;
			else{
				i--;
			}
		}
		friends.add(array);
		
		decisionPercent.add( (IQ-2)*0.1 + dp);
		
		went.add(new boolean[numweeks]);
		success.add(new boolean[numweeks]);
	}
	
	/**
	 * Calculates if the user decides to go with their IQ level
	 * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 * @return boolean
	 */
	public boolean strategy(int week, State s){
		int iq = 1;
		boolean []decision = new boolean[3];
		Random r = new Random();
		double gp = s.gamepercentage.get(s.iteration);
		double[] ps = s.parksuccess.get(s.iteration);
		boolean[] ss = success.get(s.iteration);
		boolean[] w = went.get(s.iteration);
		boolean lastweek = w[week-1];
		double var = .8;
		
		//IQ1: If last week is successful, then he does what he did last week
		decision[0] = ss[week-1] ? w[week-1] : !w[week-1];
		
		if(IQ == iq)
			return r.nextDouble() < var ? decision[0] : !decision[0];
		
		iq++;

		int timeswent = (ss[week-3] ? 1 : 0) + (ss[week-2] ? 1 : 0) + (ss[week-1] ? 1 : 0);
		int choice = r.nextInt(2);
			decision[1] = ((timeswent < 2) && (!w[week-1] || !w[week-2])) || (ps[week-1] < gp && ps[week-1] < ps[week-2]);
		
		/*IQ2: If he went less then 2 times in the last three weeks
		 * And (Either he didn't go last two weeks in a row or last week was a park success) 
		 * And park success 2 weeks ago was higher than last week
		 * 
		 */
		decision[1] = r.nextDouble() < var ? decision[1] : !decision[1];

		if(IQ == iq)
			return decision[1];
		iq++;
		
		double numgoing = ((decision[1] ? var : (1-var)) + Math.abs(r.nextGaussian()*.1)+.5) * .333;
		double diff = gp - numgoing;
		double perc = 0;
		if(diff > .333){
			decision[2] = true;
		} else if(diff < 0){
			decision[2] = false;
		} else if(diff > .1666){
			perc = (diff / .333) *.9;
			decision[2] = r.nextDouble() < perc ? true : false;
		} else{
			perc = (diff / .333) * .9;
			decision[2] = r.nextDouble() < perc ? true : false;
		}
		System.out.println("numgoing " +numgoing + " diff "+diff+ " perc "+perc);
		
		 //IQ3:  Maximize the percentage of IQ2 people who go and maximizes the percent
		return decision[2];
	}
	
	/**
	 * Calculates friend factor (how much friends effect their final decision)
	 * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 * @return double
	 */
	public double friendfactor(int week, State s){
		double ff = 0;
		int size = friends.size();
		int len = friends.get(size-1).length;
		
		//Adds up the friend's experience 
		for(int i = 0; i < len; i++){
			Individual friend = s.get(friends.get(size-1)[i]);
			ff += friend.went.get(s.iteration)[week-1] ? friend.experience.get(s.iteration) : 0;
		}
		return ff/2;
	}
	
	/**
	 * Calculates the final decision of the individual
	 * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 * @return boolean
	 */
	public boolean decision(int week, State s){
		double ff = friendfactor(week, s);
		double weather = s.weather.get(s.iteration) - this.weather.get(s.iteration) + 1;
		
		double dp = decisionPercent.get(s.iteration);
		Random r = new Random();
		int strategy = strategy(week, s) ? 1 : 0;
		
		//Factors other than their decision making with the IQ
		double others = ff + weather + (skill.get(s.iteration) + experience.get(s.iteration))*1.5;
		double decision =  dp*strategy + (1-dp)*0.25 * others;

		return decision > .5;
	}

}
