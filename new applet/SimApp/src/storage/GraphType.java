package storage;



import java.awt.FlowLayout;

import javax.swing.ButtonGroup;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JToggleButton;

/**
 * GUI Class: Defines what type of graph each graph shows
 * @author
 *
 */
public class GraphType extends JPanel{

	private static final long serialVersionUID = 1L;
	JLabel type;
	JRadioButton last;
	JRadioButton overall;
	
	/**
	 * Constructor for GraphType()
	 */
	public GraphType() {
		super();
		type = new JLabel("Type of Graph:");
		last = new JRadioButton("Last Iteration Only");
		overall = new JRadioButton("All Iterations Averaged");
		
		ButtonGroup bg = new ButtonGroup();
		bg.add(last);
		bg.add(overall);
		
		setLayout(new FlowLayout(FlowLayout.CENTER));
		/*
		 * add(type);
		add(last);
		add(overall);
		*/
	}
	
	/**
	 * Returns true if the radio button is selected
	 * @return
	 */
	public boolean isaverage(){
		if(overall.isSelected())
			return true;
		return false;
	}

}
