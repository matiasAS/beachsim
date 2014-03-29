package view;

import java.awt.Font;
import java.awt.GridLayout;
import java.text.DecimalFormat;

import javax.swing.JPanel;
import javax.swing.JLabel;

/**
 * Outputs the average park attendance, last park success, and overall park success as a text
 * @author
 *
 */
public class Output extends JPanel{

	private static final long serialVersionUID = 1L;
	
	public JLabel avg;
	public JLabel lips;
	public JLabel ops;
	
	GridLayout gl = new GridLayout(1,1,2,2);
	
	String avgstart = "Average Park Attendance: ";
	String lipsstart = "Last Iteration Attendance: ";
	String opsstart = "Overall Park Success: ";
	
	/**
	 * Constructor for output
	 */
	public Output(){
		avg = new JLabel(avgstart + "(no runs yet)");
		lips = new JLabel(lipsstart + "(no runs yet)");
		ops = new JLabel(opsstart + "(no runs yet)");
		
		avg.setFont(new Font("sansserif", Font.BOLD, 16));
		lips.setFont(new Font("sansserif", Font.BOLD, 16));
		ops.setFont(new Font("sansserif", Font.BOLD, 16));
		
		setLayout(gl);
		/*
		add(avg);
		
		add(ops);*/
		add(lips);
	}
	
	/**
	 * Sets text field to the requested parameter value
	 * @param average: Average Park Attendance
	 * @param iteration: Last Iteration Park Success
	 * @param overall: Overall Park Success
	 */
	public void setOutputs(double average, double iteration, double overall){
        DecimalFormat df = new DecimalFormat("#.####");
        String printnull = "(no runs yet)";
        if(average < 0){
            avg.setText(avgstart+ printnull);
    		lips.setText(lipsstart + printnull);
    		ops.setText(opsstart + printnull);
        } else{
        	avg.setText(avgstart+ df.format(average));
        	lips.setText(lipsstart + df.format(iteration));
        	ops.setText(opsstart + df.format(overall));
        }
        
		this.repaint();
	}
}
