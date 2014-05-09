package view;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.Toolkit;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

import control.*;
/**
 * Main GUI Class
 */
public class Main extends JFrame {


	private static final long serialVersionUID = 1L;
	public static Details d;
	public static GraphButtons b;
	public static Output o;
	public static Graph g;
	public static Title t;
	public static SwitchUser su;
	public static GraphType gt;
	
	public static Logic l;
	public static Compute c;
	public static Update u;
	
	GridBagLayout gb;
	GridBagConstraints gc;
	public static Main m;
	
	public static double gamepercentage;
	public static int numberofskiers;
	public static int lengthofsimulation;
	public static double weather;
	public static int averagenumberoffriends;
	
	public static boolean resort = false;
	public static double experiencepercent = .5;
	public static int skilllevel = 5;
	public static double decisionpercent = .5;
	
	public Main(){
		super("Ski Resort Simulator");
		
		
		
		t = new Title();
		gt = new GraphType();
		d = new Details(gt);
		g = new Graph();
		b = new GraphButtons();
		o = new Output();
		su = new SwitchUser();
		
		gb = new GridBagLayout();
		setLayout(gb);
		
		gc = new GridBagConstraints();
		gc.gridx = 0;
		gc.gridy = 0;
		gc.gridwidth = GridBagConstraints.REMAINDER;
		gc.gridheight = 1;
		gb.setConstraints(t, gc);
		gc.insets = new Insets(40,40,40,40);
		t.setBorder(BorderFactory.createLineBorder(Color.black));
		add(t);
		
		gc = new GridBagConstraints();
		gc.gridx = 0;
		gc.gridy = 1;
		gc.gridwidth = 1;
		gc.gridheight = 3;
		gb.setConstraints(d, gc);
		add(d);
		
		gc = new GridBagConstraints();
		gc.gridx = 1;
		gc.gridy = 1;
		gc.gridwidth = 1;
		gc.gridheight = 1;
		gc.fill = GridBagConstraints.BOTH;
		gc.weighty = 1;
		gb.setConstraints(g, gc);
		add(g);

		gc = new GridBagConstraints();
		gc.insets = new Insets(20,20,20,20);
		gc.gridx = 1;
		gc.gridy = 2;
		gc.gridwidth = 1;
		gc.gridheight = 1;
		gc.anchor = GridBagConstraints.SOUTH;
		gb.setConstraints(gt, gc);
		add(gt);
		
		gc = new GridBagConstraints();
		gc.insets = new Insets(20,20,20,20);
		gc.gridx = 1;
		gc.gridy = 3;
		gc.gridwidth = 1;
		gc.gridheight = 1;
		gc.anchor = GridBagConstraints.SOUTH;
		gb.setConstraints(b, gc);
		b.setBorder(BorderFactory.createLineBorder(Color.black));
		add(b);
		
		gc = new GridBagConstraints();
		gc.gridx = 0;
		gc.gridy = 4;
		gc.gridwidth = 1;
		gc.gridheight = 1;
		gc.insets = new Insets(20,20,20,20);
		gb.setConstraints(su, gc);
		add(su);
		
		gc = new GridBagConstraints();
		gc.gridx = 1;
		gc.gridy = 4;
		gc.gridwidth = 1;
		gc.gridheight = 1;
		gc.insets = new Insets(20,20,20,20);
		gb.setConstraints(o, gc);
		add(o);
		
		pack();
	}
	/**
	 * Main method
	 * @param args
	 */
	public static void main(String[] args) {
		resort = true;
		m = new Main();
		m.addWindowListener(new WindowAdapter(){
			public void windowClosing(WindowEvent e){
				//TODO
				System.exit(0);
			}
		});
	
		m.setMinimumSize(new Dimension(900,650));
		m.setResizable(true);
		Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
		m.setLocation(d.width/2-m.getWidth()/2,
					  d.height/2-m.getHeight()/2);
		m.setVisible(true);
		m.setJMenuBar(t.menubar);
		
	}
	/**
	 * Checks the text input values to see if they are valid
	 * @return
	 */
	public static boolean checkInputs(){
		gamepercentage = Double.parseDouble(d.gptext.getText()) / 100;
		if(gamepercentage < .1  || gamepercentage > .9)
			return false;
		
		numberofskiers = Integer.parseInt(d.nostext.getText());
		if(numberofskiers < 100)
			return false;

		lengthofsimulation = Integer.parseInt(d.lostext.getText());
		if(lengthofsimulation < 10)
			return false;

		weather = Double.parseDouble(d.wtext.getText()) / 60;
		if(weather < 0 || weather > 1)
			return false;

		averagenumberoffriends = Integer.parseInt(d.anftext.getText());
		if(averagenumberoffriends < 1 || averagenumberoffriends > 8)
			return false;

		if(resort){
			experiencepercent = Double.parseDouble(d.eptext.getText()) / 100;
			if(experiencepercent < 0 || experiencepercent > 1)
				return false;

			skilllevel = Integer.parseInt(d.sltext.getText()) / 10;
			if(skilllevel < 0 || skilllevel > 1)
				return false;
		} else{
			decisionpercent = Double.parseDouble(d.dptext.getText()) / 100;
			if(decisionpercent < 0 || decisionpercent > 1)
				return false;
		}
		
		return true;
	}
}
