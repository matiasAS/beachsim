package control;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Random;

import javax.swing.JOptionPane;

import model.Individual;
import model.State;
import view.Main;

/**
 * Starts the computation of the simulation. Saves or load if needed for simulation
 * @author
 *
 */
public class Logic {
	
	public static State s = null;
	public static double weather;
	public static double weekweather;
	static Random r;
	public static boolean saved;
	
	/**
	 * Call to start the simulation
	 * @return 
	 */
	public static void begin(){
		if(s == null){
			saved = false;
			s = new State(Main.d);
		} else{
			Update.variables(s, Main.d);
		}
		s.refreshskiierstats();
		Compute.s = s;
		
		r = new Random(System.currentTimeMillis());
		weather = s.weather.get(s.iteration);
		weekweather = weather + r.nextGaussian()/6;
		while(weekweather > 1 || weather < 0)
			weekweather = weather + r.nextGaussian()/6;
		
		s.parksuccess.add(new double[s.numberofweeks]);
		
		runSimulation();
	}
	
	/**
	 * Runs the simulation for the week and updates the field values (Calculates the success rate)
	 * @return 
	 */
	public static void runSimulation(){
		Main.b.setButtonsEnabled(true);
		Main.d.nostext.setEditable(false);
		Main.d.lostext.setEditable(false);
		
		for(int i = 0; i < s.numberofskiiers; i++){
			s.get(i).went.add(new boolean[s.numberofweeks]);
			s.get(i).success.add(new boolean[s.numberofweeks]);
		}

		//updates all the field variables and the success of each individual for each week
		for(int i = 0; i < s.numberofweeks; i++){
			for(int j = 0; j < s.numberofskiiers; j++){
				Individual x = s.get(j);
				if(i < (x.IQ+1))
					x.went.get(s.iteration)[i] = r.nextBoolean();
				else{
					boolean go = x.decision(i, s);
					x.went.get(s.iteration)[i] = go;
				}
			}
			Update.globals(s, i);
			Update.skiiers(s, i);
		}
		Update.outputs(s);
		
		s.iteration++;
		Update.skiiersuccess();
		Main.g.setGraph(Compute.getdefaultgraph());
	}
	
	/**
	 * Saves the state to a file
	 * @param filename: File namespace the file is saved to
	 */
	public static void saveState(String filename){
		if(filename == null){
			filename = s.filename;
		} else{
			s.filename = filename;
		}
		saved = true;
    	try {
			FileOutputStream fos = new FileOutputStream(new File(filename));
			ObjectOutputStream oos;
			try {
				oos = new ObjectOutputStream(fos);
				oos.writeObject(s);
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	/**
	 * Loads state from the file
	 * @param filename: loads the field values from the state
	 */
	public static void loadState(String filename){
		saved = true;
		
    	try {
			FileInputStream fis = new FileInputStream(new File(filename));
			ObjectInputStream i = new ObjectInputStream(fis);
			State state = (State) i.readObject();
			
			if(Main.resort != state.resort){
				JOptionPane.showMessageDialog(null,
					    "Incompatible file. Cannot open\n" +
					    "Individual State when running Ski\n" +
					    "Resort State, and vice versa.",
					    "Load error",
					    JOptionPane.ERROR_MESSAGE);
			} else{
				s = state;
				s.filename = filename;
				Update.outputs(s);
			}
			i.close();
			fis.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    	
	}
	
}
