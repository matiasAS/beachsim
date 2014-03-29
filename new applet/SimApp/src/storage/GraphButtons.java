package storage;

import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import org.jfree.chart.JFreeChart;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;


/**
 * GUI class for all the buttons 
 * @author
 *
 */
public class GraphButtons extends JPanel{
	
	private static final long serialVersionUID = 1L;
	
	public JLabel label;
	
	public JButton nf;
	public JButton gp;
	public JButton w;

	public JButton other1;
	public JButton other2;
	
	GridLayout gl =  new GridLayout(1,2,2,2);
	
	
	/**
	 * Constructor for GraphButtons
	 */
	public GraphButtons(){
		
		label = new JLabel("  Graphs vs. Success Rate:");
		
		nf = new JButton("Number of Friends");
		gp = new JButton("Game Percentage");
		w = new JButton("Weather Preference");
		
		setLayout(gl);
		/*
		add(label);
		add(nf);
		add(gp);
		add(w);
		add(other1);
		add(other2);
		*/
		setButtonsEnabled(false);

		
	}

	/**
	 * Sets button to be clickable on set to true 
	 * @param set: true on enable, false on disable
	 */
	public void setButtonsEnabled(boolean set){
		nf.setEnabled(set);
		gp.setEnabled(set);
		w.setEnabled(set);
		other1.setEnabled(set);
		other2.setEnabled(set);
	}
	
	/**
	 * On toggle, sets the text to the respective mode and validates the value
	 * @param toind
	 */
	public void switchuser(boolean toind){

		if(toind){
			other1.setText("Attendance Rate");
			other2.setText("IQ (1 - 3)");
		} else{
			other1.setText("Skill Level");
			other2.setText("First-Day Experience");
		}
		validate();
	}
	
	/**
	 * ActionListener class that listens for button inputs
	 * 
	 */
	
	}

