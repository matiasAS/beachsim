package storage;



import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Hashtable;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JSlider;
import javax.swing.JTextField;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

import org.jfree.chart.JFreeChart;

/**
 * GUI class for all the text field 
 * @author 
 *
 */
public class Details extends JPanel{

	private static final long serialVersionUID = 1L;

	public JButton gp;
	public JLabel nos;
	public JLabel los;
	public JLabel genderratio;
	public JLabel demographics;
	public JButton w;
	public JButton anf;
	public JTextField gptext;
	public JTextField nostext;
	public JTextField lostext;
	public JTextField wtext;
	public JTextField anftext;
	public JTextField poptext;
	public JLabel title;
	public JLabel population;
	public JLabel w2;
	public JButton ep;
	public JButton sl;
	public JTextField eptext;
	public JTextField sltext;

	public JLabel dp;
	public JTextField dptext;
	GridLayout gl;
	GraphType gt;
	/**
	 * Constructor for Details
	 */
	class SliderListener implements ChangeListener {
	    public void stateChanged1(ChangeEvent e) {
	        JSlider source = (JSlider)e.getSource();
	        if (!source.getValueIsAdjusting()) {
	            int fps = (int)source.getValue();
	        }    
	    }

		@Override
		public void stateChanged(ChangeEvent arg0) {
			// TODO Auto-generated method stub
			
		}
	}
	public Details(GraphType gt){
		this.gt = gt;
		gp = new JButton("Game Percentage (10 - 90) - Click to Test");
		nos = new JLabel("Number of Skiers ( >= 100):");
		los = new JLabel("Length of Simulation (in weeks >= 10):");
		population = new JLabel("Population: ");
		w = new JButton("Temperature (in Fahrenheit, 0 - 60)");
		w2 = new JLabel("Temperature (in Fahrenheit, 0 - 60)");
		anf = new JButton("Average Number of Friends per Skier (1 - 8) - Click to Test");
		demographics =new JLabel("Demographics");
		genderratio =new JLabel("Gender Ratio: ");
		gptext = new JTextField(20);
		gptext.setText("60");
		poptext =new JTextField(20);
		poptext.setText("100000");
		nostext = new JTextField(20);
		nostext.setText("1000");
		lostext = new JTextField(20);
		lostext.setText("10");
		wtext = new JTextField(20);
		wtext.setText("30");
		anftext = new JTextField(20);
		anftext.setText("4");
		final char FPS_MIN = 0;
		final int FPS_MAX = 100;
		final int FPS_INIT = 50;    //initial frames per second
		JSlider framesPerSecond = new JSlider(JSlider.HORIZONTAL,
		                                      FPS_MIN, FPS_MAX, FPS_INIT);
		
		framesPerSecond.addChangeListener(new SliderListener());

		//Turn on labels at major tick marks.
		framesPerSecond.setMajorTickSpacing(10);
		framesPerSecond.setMinorTickSpacing(1);
		framesPerSecond.setPaintTicks(true);
		Hashtable labelTable = new Hashtable();
		labelTable.put( new Integer( 0 ), new JLabel("Male") );
		labelTable.put( new Integer( FPS_MAX ), new JLabel("Female") );
		framesPerSecond.setLabelTable( labelTable );
		framesPerSecond.setPaintLabels(true);
		
		
		
		title = new JLabel("Input All Fields Below: ");
		title.setFont(new Font("sansserif", Font.BOLD, 16));
		
		gptext.grabFocus();
			ep = new JButton("Daily Experience Percentage (0 - 100) - Click to Test");
			sl = new JButton("Average Skill Level (1 - 10) - Click to Test");
			eptext = new JTextField(20);
			eptext.setText("50");
			sltext = new JTextField(20);
			sltext.setText("5");
			
			gl = new GridLayout(8,1,1,1);
			
			setLayout(gl);
			add(title);
			add(population);
			add(poptext);
			add(w2);
			add(wtext);
			add(demographics);
			add(genderratio);
			add(framesPerSecond);
	}
{
			
			add(gp);
		add(gptext);
			
			add(nos);
			add(nostext);
			
			add(los);
			add(lostext);
			
			add(anf);
			add(anftext);
			add(ep);
			add(eptext);
			add(sl);
			add(sltext);}}
			
		
	
	/**
	 * Clears all the inputs of the text field
	 * @return
	 */
	
