

import java.io.*;
import java.awt.*;
import java.util.*;
import java.applet.*;

import javax.swing.*;

import java.awt.event.*;

import javax.swing.event.*;
import javax.swing.plaf.SliderUI;

import org.jfree.chart.ChartPanel;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.axis.NumberAxis;
import org.jfree.chart.axis.ValueAxis;
import org.jfree.chart.plot.CombinedDomainXYPlot;
import org.jfree.chart.plot.XYPlot;
import org.jfree.chart.renderer.xy.XYLineAndShapeRenderer;
import org.jfree.data.xy.DefaultXYDataset;


public class Simulator extends JApplet/* implements ActionListener*/{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	Button simulateButton; 
    Button exportButton; 
    Label demographics;
    Label weather;
    Label population;
    Label genderRatio;
    TextField weatherT;
    TextField populationT;
    private Double xLowerBound = null;
    private Double xUpperBound = null;
 
    private double redSeries[][];// = new double[1000][1000];
 
    private JProgressBar pb = new JProgressBar();
    public void init()  
    { 
    	setSize(830,768);
    	
 // Now we will use the FlowLayout 
         setLayout(new FlowLayout(FlowLayout.LEFT, 15, 15)); 
         demographics = new Label ("Demographics: ");;
         weather = new Label ("Weather: ");;
         population = new Label ("Population: ");
         genderRatio = new Label ("Gender Ratio: ");
         weatherT = new TextField("Enter Weather Here.",35);
         populationT = new TextField("Enter Population Here.",35);
         simulateButton = new Button("Simulate"); 
         exportButton = new Button("Export"); 
         String filePrefix = getParameter("filePrefix");
         
         String pointFilePath = filePrefix + "_raw_bincounts";
         String segmentFilePath = filePrefix + "_segmented_out";
  
         redSeries = new double[2][5];
  
         //Set the x coordinate of the 5 red points.
         redSeries[0][0] = 1;
         redSeries[0][1] = 2;
         redSeries[0][2] = 3;
         redSeries[0][3] = 4;
         redSeries[0][4] = 5;
  
         //Set the y coordinate of the 5 red points.
         redSeries[1][0] = 2;
         redSeries[1][1] = 2;
         redSeries[1][2] = 3;
         redSeries[1][3] = 3;
         redSeries[1][4] = 4;
  
  
         xLowerBound = Double.parseDouble("0");
         xUpperBound = Double.parseDouble("6");
  
         // Get the graph (generateGraph will create the JFreeChart graph and add the red and blue point on it).
         JFreeChart jFreeChart = generateGraph();
  
         //Put the jFreeChart in a chartPanel
         ChartPanel chartPanel = new ChartPanel(jFreeChart);
         chartPanel.setPreferredSize(new Dimension(800,600));
  
         chartPanel.setPopupMenu(null);
         //add the chartPanel to the container (getContentPane is inherited from JApplet which AppletGraph extends).
         Container content = getContentPane();
         

 		// add it to the applet
 		
 		// register this applet as a listener for the object
         /*add(nameField);*/
         
         content.add(chartPanel);
         addNewLine();
         add(simulateButton);
         add(exportButton);
         addNewLine();
         add(population);
         add(populationT);
         add(weather);
         add(weatherT);
         add(demographics);
         add(genderRatio);
 // Attach actions to the components 
         /*
         simulateButton.addActionListener(this); 
         exportButton.addActionListener(this); */
        }
    
    private void addNewLine()
    {
       // Add a Canvas 10000 pixels wide but 
       // only 1 pixel high, which acts as
       // a horizontal line.
       Canvas line = new Canvas( );
       line.setSize(10000, 1);
       add(line);
    }
    public JFreeChart generateGraph(){
    	 
        DefaultXYDataset defaultXYDataset = new DefaultXYDataset();
 
 
 
        String redSeriesLabel = "Attendance Rate";
        if(redSeries != null){
            defaultXYDataset.addSeries(redSeriesLabel, redSeries);
        }else{
            //TODO
            //throw new SolexaGraphException("pointSeries was null : you should frist call the plotGraphDrawer.setSegmentSeriesFromFile(String fileAbsolutePath()");
        }
 
        ValueAxis abscisse = new NumberAxis("Day");
        ValueAxis ordonate = new NumberAxis("Attendance");
        CombinedDomainXYPlot combinedDomainXYPlot = new CombinedDomainXYPlot(abscisse);
 
        XYLineAndShapeRenderer xyLineAndShapeRenderer = new XYLineAndShapeRenderer();
 
        xyLineAndShapeRenderer.setSeriesPaint(0, Color.RED);
        xyLineAndShapeRenderer.setSeriesPaint(1, Color.BLUE);
 
        Dimension dimension = new Dimension(1,1);
        Shape shape = new Rectangle(dimension);
        xyLineAndShapeRenderer.setSeriesShape(0, shape);
        xyLineAndShapeRenderer.setSeriesShape(1, shape);
 
 
        xyLineAndShapeRenderer.setSeriesLinesVisible(0, false);
        xyLineAndShapeRenderer.setSeriesLinesVisible(1, false);
        xyLineAndShapeRenderer.setSeriesShapesVisible(0, true);
        xyLineAndShapeRenderer.setSeriesShapesVisible(1, true);
 
        xyLineAndShapeRenderer.setPlot(combinedDomainXYPlot);
 
        XYPlot xyPlot = new XYPlot(defaultXYDataset,abscisse,ordonate,xyLineAndShapeRenderer);
 
        xyPlot.setDataset(defaultXYDataset);
 
        if(xLowerBound != null && xUpperBound != null){
            xyPlot.getDomainAxis().setLowerBound(xLowerBound);
            xyPlot.getDomainAxis().setUpperBound(xUpperBound);
        }
        combinedDomainXYPlot.add(xyPlot);
 
 
        JFreeChart jFreeChart = new JFreeChart(combinedDomainXYPlot);
 
        return jFreeChart;
    }
// Here we will show the results of our actions 
        public void paint(Graphics g) 
        { 

         g.setColor(Color.black);

 // Now that the color is set you can get the text out the TextField 
 // like this 
    }

// When the button is clicked this method will get automatically called 
// This is where you specify all actions.

      /* public void actionPerformed(ActionEvent evt)  
        { 
 // Here we will ask what component called this method 
             if (evt.getSource() == simulateButton)  
  // So it was the okButton, then let's perform his actions 
  // Let the applet perform Paint again. 
  // That will cause the aplet to get the text out of the textField 
  // again and show it. 
                  ;

 // Actions of the wrongButton 
         else if (evt.getSource() == exportButton)  
         
        	 ;
          
    } */

} 

