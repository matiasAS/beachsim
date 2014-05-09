package storage;



import java.awt.BorderLayout;

import javax.swing.JLabel;
import javax.swing.JPanel;

import org.jfree.chart.ChartPanel;
import org.jfree.chart.ChartUtilities;
import org.jfree.chart.JFreeChart;

/**
 * GUI for graphical output
 * @author
 *
 */
public class Graph extends JPanel{

	private static final long serialVersionUID = 1L;
	
	public JLabel graph;
	
	/**
	 * Constructor for Graph
	 */
	public Graph(){
		graph = new JLabel("Graph Goes Here");
		add(graph);
	}
	
	/**
	 * Sets graph for a specified chart
	 * @param chart: chart to graph
	 */
	public void setGraph(JFreeChart chart){
		this.removeAll();
		setLayout(new BorderLayout());
		ChartPanel cp = new ChartPanel(chart);
		add(cp, BorderLayout.CENTER);
		revalidate();
	}
}
