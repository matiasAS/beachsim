package model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Random;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import view.Details;
import view.Main;
import control.Update;

/**
 * Saves the global variables and the field lists to a state
 * @author
 *
 */
public class State extends ArrayList<Individual> implements Serializable{

	private static final long serialVersionUID = 1L;
	/**
	 * Number of week the simulation is running for
	 */
	public int iteration;
	/**
	 * Lists of past success of the simulated park
	 */
	public ArrayList<double[]> parksuccess;
	/**
	 * Number of peers simulated
	 */
	public int numberofskiiers;
	/**
	 * The current week the simulation is on
	 */
	public int numberofweeks;
	/**
	 * List of past iteration's game percentage
	 */
	public ArrayList<Double> gamepercentage;
	/**
	 * List of past iteration's weather
	 */
	public ArrayList<Double> weather;
	/**
	 * List of past number of friends
	 */
	public ArrayList<Double> numberoffriends;
	/**
	 * List of past iteration's experience percent
	 */
	public ArrayList<Double> experiencepercent;
	/**
	 * List of past iteration's skill level
	 */
	public ArrayList<Double> skilllevel;
	/**
	 * List of past iteration's decision percent
	 */
	public ArrayList<Double> decisionpercent;
	/**
	 * The file namespace the user is saving to
	 */
	public String filename;
	/**
	 * Equals true when the simulation is currently on resort mode, false if simulation is in individual mode
	 */
	public boolean resort;
	
	/**
	 * Constructor for State
	 * @param d: Text field input data from user
	 */
	public State(Details d){
		this.iteration = 0;
		this.gamepercentage = new ArrayList<Double>();
		this.weather = new ArrayList<Double>();
		this.numberoffriends = new ArrayList<Double>();
		this.experiencepercent = new ArrayList<Double>();
		this.skilllevel = new ArrayList<Double>();
		this.decisionpercent = new ArrayList<Double>();
		Update.variables(this, d);
		this.resort = Main.resort;
		this.parksuccess = new ArrayList<double[]>();
		//Creates a list with individual objects with given details
		for(int i = 0; i < numberofskiiers; i++){
			this.add(new Individual(i, numberofskiiers, numberofweeks, weather.get(iteration), numberoffriends.get(iteration), skilllevel.get(iteration), decisionpercent.get(iteration), experiencepercent.get(iteration)));
		}
	}
	
	/**
	 * Multithread class that processes each separate thread for individuals
	 */
	private class Processor extends Thread{
		
		Individual x;
		Random r;
		int numberofskiiers;
		int numberofweeks;
		double weather;
		double numberoffriends;
		double skillevel;
		double decisionpercent;
		double experiencepercent;
		
		Processor(Individual x, Random r, int numberofskiiers, int numberofweeks, double weather, double numberoffriends, double skillevel, double decisionpercent, double experiencepercent){
			this.x = x;
			this.r = r;
			this.numberofskiiers = numberofskiiers;
			this.numberofweeks = numberofweeks;
			this.weather = weather;
			this.numberoffriends = numberoffriends;
			this.skillevel = skillevel;
			this.decisionpercent = decisionpercent;
			this.experiencepercent = experiencepercent;
		}
		
		public void run(){
			x.setvalues(new Random(), numberofskiiers, numberofweeks, weather, numberoffriends, skilllevel.get(iteration), decisionpercent, experiencepercent);					
		}
	}
	
	/**
	 * Cleans the field stats of the skiiers
	 */
	public void refreshskiierstats(){
		long time = System.currentTimeMillis();
		
		ExecutorService manager = Executors.newFixedThreadPool(10);
		
		for(Individual x : this){
			manager.submit(new Processor(x, new Random(), numberofskiiers, numberofweeks, weather.get(iteration), numberoffriends.get(iteration), skilllevel.get(iteration), decisionpercent.get(iteration), experiencepercent.get(iteration)));
		}
		manager.shutdown();
		
		System.out.println("Time: "+(System.currentTimeMillis() - time));
	}

}
