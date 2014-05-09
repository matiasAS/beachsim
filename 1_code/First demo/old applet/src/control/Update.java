package control;

import java.util.Random;

import view.Details;
import view.Main;
import model.Individual;
import model.State;

/**
 * Updates the field variable of the current simulation
 *  written by: Erjon Malaj
 *  tested by:
 *  debugged by: 
 *
 */
public class Update {
	
	public static void skiiersuccess(){
		State s = Compute.s;
		
		for(Individual x : s){
			double went = 0;
			double successes = 0;
			int total = 0;
				for(int j = 0; j < s.numberofweeks; j++){
					if(x.went.get(s.iteration-1)[j])
						went++;
					if(x.success.get(s.iteration-1)[j])
						successes++;
					total++;
				}
			x.wentpercent.add(went / total);
			x.successpercent.add(successes / total);
		}
	}

	/**
	 * Updates the skiiers' field value for the week
     * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 */
	public static void skiiers(State s, int week){
		
		for(int i = 0; i < s.numberofskiiers; i++){
			
			//determine if week was personal success
			Individual x = s.get(i);
			if( (s.parksuccess.get(s.iteration)[week] > s.gamepercentage.get(s.iteration) && x.went.get(s.iteration)[week]) ||
				(s.parksuccess.get(s.iteration)[week] < s.gamepercentage.get(s.iteration) && !x.went.get(s.iteration)[week]))
				x.success.get(s.iteration)[week] = false;
			else
				x.success.get(s.iteration)[week] = true;
			
			//experience this week based on experience last week.. if you had a good time last week,
			//more likely you'll have a good time this week as well
			Random r = new Random();
			double newexp, add = x.experience.get(s.iteration); 
			x.experience.add(add);
		}	
	}
	
	/**
	 * Updates the global variable for the simulation
     * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 */
	public static void globals(State s, int week){
		//update weekly weather
		Logic.weather = s.weather.get(s.iteration);
		Logic.weekweather = Logic.weather + Logic.r.nextGaussian()/6;
		while(Logic.weekweather > 1 || Logic.weather < 0)
			Logic.weekweather = Logic.weather + Logic.r.nextGaussian()/6;
		
		//calculate park success
		int went = 0;
		for(int i = 0; i < s.numberofskiiers; i++){
			Individual x = s.get(i);
			if(x.went.get(s.iteration)[week])
				went++;
		}
		s.parksuccess.get(s.iteration)[week] = ((double) went) / s.numberofskiiers;
	}
	
	/**
	 * Updates the other variables (gamepercentage, numberofskiiers, weeks, weather)
     * @param week: Number of week the simulation is on
	 * @param s: Current state which stores the field variables
	 */
	public static void variables(State s, Details d){
		s.gamepercentage.add(Double.parseDouble(d.gptext.getText())/100);
		s.numberofskiiers = Integer.parseInt(d.nostext.getText());
		s.numberofweeks = Integer.parseInt(d.lostext.getText());
		s.weather.add(Double.parseDouble(d.wtext.getText()) / 60);
		s.numberoffriends.add(Double.parseDouble(d.anftext.getText()));
		
		if(Main.resort){
			s.experiencepercent.add(Double.parseDouble(d.eptext.getText()) / 100);
			s.skilllevel.add(Double.parseDouble(d.sltext.getText()) / 10);
			s.decisionpercent.add(.5);
		} else{
			s.experiencepercent.add(.5);
			s.skilllevel.add(.5);
			s.decisionpercent.add(Double.parseDouble(d.dptext.getText()) / 100);
		}
	}
	
	/**
	 * Outputs the update onto the main window
	 * @param s Current state which stores the field variables
	 */
	public static void outputs(State s){
		double iterationsuccess = 0;
		double overallsuccess = 0;
		double average = 0;
		
		for(int j = 0; j <= s.iteration; j++){
			iterationsuccess = 0;
			for(int i = 0; i < s.numberofweeks; i++){
				average += s.parksuccess.get(j)[i];
				iterationsuccess += s.parksuccess.get(j)[i] > (s.gamepercentage.get(s.iteration)) ? 0 : 1;
			}
			average /= s.numberofweeks;
			System.out.println(iterationsuccess+" "+s.numberofweeks);
			iterationsuccess /= s.numberofweeks;
			overallsuccess += iterationsuccess / (s.iteration+1);
		}
		
		Main.o.setOutputs(average, iterationsuccess, overallsuccess);
	}

}
