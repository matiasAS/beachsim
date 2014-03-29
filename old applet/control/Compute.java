package control;

import java.util.Arrays;

import org.jfree.chart.ChartFactory;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.plot.PlotOrientation;
import org.jfree.data.category.DefaultCategoryDataset;
import org.jfree.data.xy.XYSeries;
import org.jfree.data.xy.XYSeriesCollection;

import model.Individual;
import model.State;

/**
 * Computes the graphical output to view on GUI
 * @author
 *
 */
public class Compute {

	/**
	 * Current state which stores the field variables
	 */
	public static State s;
	private enum Type { LINE, AREA, SCATTER };
	
	/**
	 * Calculates graph for the park attendance (success rate) for the set amount of weeks
	 * @return
	 */
	public static JFreeChart getdefaultgraph() {
		XYSeries series = new XYSeries("Success Rate");

		for (int i = 0; i < s.numberofweeks; i++) {
			int it = s.iteration;
			series.add(i + 1, 100 * s.parksuccess.get(it - 1)[i]);
		}

		return getgraph(Type.LINE, s.numberofweeks, null, "Time Series: Park Attendance as Weeks Progress", "Week", true, series);
	}

	/**
	 * Calculates graph for the number of friends vs the success rate
	 * @return
	 */
	public static JFreeChart getnumfriends() {
		double[][] bars = new double[8][2];

		for (Individual x : s) {
			int size = x.friends.size();
			int len = x.friends.get(size-1).length;
			int nf = len - 1;
			bars[nf][0]++;
			bars[nf][1] += x.successpercent.get(s.iteration-1);
		}

		return getgraph(Type.AREA, 8, bars, "Number of Friends vs. Success Rates", "Number of Friends", false, null);
	}

	/**
	 * Calculates graph for the game percentage vs the success rate
	 * @return
	 */
	public static JFreeChart getgameperc() {
		int size = s.gamepercentage.size();
		XYSeries series = new XYSeries("Success Rate");

		for (int i = 0; i < size; i++) {
			double success = 0;
			for(int j = 0; j < s.numberofweeks; j++){
				if(s.parksuccess.get(i)[j] < s.gamepercentage.get(i))
					success++;
			}
			Double percent = 100 * s.gamepercentage.get(i);
			System.out.println(percent);
			series.add(percent.intValue(), success/s.numberofweeks);
		}

		return getgraph(Type.LINE, size, null, "Game Percentage vs. Success Rates", "Game Percentage - %", true, series);
	}

	/**
	 * Calculates graph for the weather preference vs the success rate
	 * @return
	 */
	public static JFreeChart getweatherpref() {
		double[][] bars = new double[60][2];
		
		for(Individual x : s){
			int index = (int)(x.weather.get(s.iteration-1)*60);
			bars[index][0]++;
			bars[index][1] += x.successpercent.get(s.iteration-1);
		}
		
		return getgraph(Type.SCATTER, 60, bars, "Weather Preference vs. Success Rates", "Weather in Degrees F", false, null);
	}

	/**
	 * Calculates graph for the skill level vs the success rate
	 * @return
	 */
	public static JFreeChart getskilllevel() {
		double[][] bars = new double[10][2];
		
		for(Individual x : s){
			int index = (int)(x.skill.get(s.iteration-1)*10);
			bars[index][0]++;
			bars[index][1] += x.successpercent.get(s.iteration-1);
		}
		
		return getgraph(Type.AREA, 10, bars, "Skill Level vs. Success Rates", "Skill", false, null);
	}

	/**
	 * Calculates graph for the experience percentage vs the success rate
	 * @return
	 */
	public static JFreeChart getexperience() {
		int size = s.experiencepercent.size();
		XYSeries series = new XYSeries("Success Rate");

		for (int i = 0; i < size; i++) {
			double success = 0;
			for(int j = 0; j < s.numberofweeks; j++){
				if(s.parksuccess.get(i)[j] < s.gamepercentage.get(i))
					success++;
			}
			Double percent = 100 * s.experiencepercent.get(i);
			System.out.println(percent);
			series.add(percent.intValue(), success/s.numberofweeks);
		}

		return getgraph(Type.LINE, size, null, "Experience Percentage vs. Success Rates", "Experience Percentage - %", true, series);
	}

	//TODO change
	/**
	 * Calculates graph for the attendance rate
	 * @return
	 */
	public static JFreeChart getattendancerate() {
		double[][] bars = new double[10][2];

		for (Individual x : s) {
			int index = (int)(10*x.wentpercent.get(s.iteration-1)) - 1;
			bars[index][0]++;
			bars[index][1] += x.successpercent.get(s.iteration-1);
		}
		
		return getgraph(Type.LINE, 10, bars, " vs. Success Rates", "Attendance Rate", false, null);

	}

	/**
	 * Calculates graph for the iq of the individual vs the success rate
	 * @return
	 */
	public static JFreeChart getiqgraph() {
		double[][] bars = new double[3][2];

		for (Individual x : s) {
			int index = x.IQ - 1;
			bars[index][0]++;
			bars[index][1] += x.successpercent.get(s.iteration-1);
			System.out.println("IQ "+x.IQ + " sp "+x.successpercent.get(s.iteration-1));
		}
		
		return getgraph(Type.AREA, 3, bars, "IQ vs. Success Rates", "IQ", false, null);
	}
	
	/**
	 * Getter for the calculated graph
	 * @param type: Type of the graph 
	 * @param num: 
	 * @param bars
	 * @param title
	 * @param xaxis
	 * @param haveseries
	 * @param series
	 * @return
	 */
	private static JFreeChart getgraph(Type type, int num, double[][] bars, String title, String xaxis, boolean haveseries, XYSeries series) {
		if(!haveseries){
			series = new XYSeries("Success Rate");
			
			for (int i = 0; i < num; i++) {
				double perc = 100 * bars[i][1] / bars[i][0];
				series.add(i + 1, perc);
				System.out.println(perc);
			}
			
		}

		XYSeriesCollection dataset = new XYSeriesCollection();
		dataset.addSeries(series);
		JFreeChart chart;
		
		if(type == Type.LINE){
			chart = ChartFactory.createXYLineChart(
					title, xaxis,
					"Success Rate - %", dataset,
					PlotOrientation.VERTICAL, true, true, false);
		} else if(type == Type.AREA){
			chart = ChartFactory.createXYAreaChart(
					title, xaxis,
					"Success Rate - %", dataset,
					PlotOrientation.VERTICAL, true, true, false);
		} else{
			chart = ChartFactory.createScatterPlot(
					title, xaxis,
					"Success Rate - %", dataset,
					PlotOrientation.VERTICAL, true, true, false);
		}
		return chart;
	}

}
