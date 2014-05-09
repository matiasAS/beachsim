package view;

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

import control.Compute;
import control.Logic;
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
	public ButtonListener bl;
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
		
		bl = new ButtonListener();
		gp.addActionListener(bl);
		w.addActionListener(bl);
		anf.addActionListener(bl);
		
		
		title = new JLabel("Input All Fields Below: ");
		title.setFont(new Font("sansserif", Font.BOLD, 16));
		
		gptext.grabFocus();
		
		if(Main.resort){
			ep = new JButton("Daily Experience Percentage (0 - 100) - Click to Test");
			sl = new JButton("Average Skill Level (1 - 10) - Click to Test");
			eptext = new JTextField(20);
			eptext.setText("50");
			sltext = new JTextField(20);
			sltext.setText("5");
			ep.addActionListener(bl);
			sl.addActionListener(bl);
			
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
			/*
			add(gp);
			add(gptext);
			
			add(nos);
			add(nostext);
			
			add(los);
			add(lostext);
			*/
			
			/*
			add(anf);
			add(anftext);
			add(ep);
			add(eptext);
			add(sl);
			add(sltext);
			*/
		}else{
			dp = new JLabel("Decision Percentage (20 - 80):");
			dptext = new JTextField(20);
			dptext.setText("50");
			gl = new GridLayout(13,1,2,2);
			
			setLayout(gl);
			add(title);
			add(gp);
			add(gptext);
			add(nos);
			add(nostext);
			add(los);
			add(lostext);
			add(w);
			add(wtext);
			add(anf);
			add(anftext);
			add(dp);
			add(dptext);
			
		}
	}
	
	/**
	 * ButtonListener for testing a range of field
	 * @author
	 *
	 */
	public class ButtonListener implements ActionListener {
		public void actionPerformed(ActionEvent e){
			String button = e.getActionCommand();
			JFreeChart chart;
			
			if(button.equalsIgnoreCase("Game Percentage (10 - 90) - Click to Test")){
				if(Main.checkInputs()){
					Main.t.begin.setText("Run Again");
					gptext.setText("10");
					Logic.begin();
					gptext.setText("50");
					Logic.begin();
					gptext.setText("90");
					Logic.begin();
				} else{
					JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
				}
				
				
				chart = Compute.getgameperc();
				gptext.setText("60");
				
			} else if(button.equalsIgnoreCase("Weather (in degrees Fahrenheit, 0 - 60) - Click to Test")){
				if(Main.checkInputs()){
					Main.t.begin.setText("Run Again");
					wtext.setText("0");
					Logic.begin();
					wtext.setText("30");
					Logic.begin();
					wtext.setText("60");
					Logic.begin();
					gt.overall.setSelected(true);
					
				} else{
					JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
				}
				
				
				chart = Compute.getweatherpref();
				wtext.setText("30");
				
			} else if(button.equalsIgnoreCase("Average Number of Friends per Skier (1 - 8) - Click to Test")){
				if(Main.checkInputs()){
					Main.t.begin.setText("Run Again");
					anftext.setText("1");
					Logic.begin();
					anftext.setText("3");
					Logic.begin();
//					anftext.setText("6");
//					Logic.begin();
					anftext.setText("8");
					Logic.begin();
					gt.overall.setSelected(true);
					
				} else{
					JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
				}
				
				anftext.setText("4");
				chart = Compute.getnumfriends();
				
			} else if(button.equalsIgnoreCase("Daily Experience Percentage (0 - 100) - Click to Test")){
				if(Main.checkInputs()){
					Main.t.begin.setText("Run Again");
					eptext.setText("5");
					Logic.begin();
					eptext.setText("50");
					Logic.begin();
					eptext.setText("95");
					Logic.begin();
					gt.overall.setSelected(true);
					
				} else{
					JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
				}
				
				eptext.setText("50");
				chart = Compute.getexperience();
				
			} else if(button.equalsIgnoreCase("Average Skill Level (1 - 10) - Click to Test")){
				if(Main.checkInputs()){
					Main.t.begin.setText("Run Again");
					sltext.setText("1");
					Logic.begin();
					sltext.setText("5");
					Logic.begin();
					sltext.setText("10");
					Logic.begin();
					gt.overall.setSelected(true);
					
				} else{
					JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
				}
				
				sltext.setText("5");
				chart = Compute.getskilllevel();
				
			} else{
				chart = Compute.getdefaultgraph();
				
			}
			Main.g.setGraph(chart);

		}

	}
	/**
	 * Enables and Disables text field base on mode (Individual or resort)
	 * @param toind
	 */
	public void switchuser(boolean toind){
		if(toind){
			remove(ep);
			remove(eptext);
			remove(sl);
			remove(sltext);
			
			dp = new JLabel("Decision Percentage (20 - 80):");
			dptext = new JTextField(20);
			dptext.setText("50");
			
			add(dp);
			add(dptext);
			title.setText("Input All Fields Below");
		} else{
			remove(dp);
			remove(dptext);
			
			ep = new JButton("Average Experience Percentage (on first day, 0 - 100):");
			sl = new JButton("Average Skill Level (1 - 10):");
			ep.addActionListener(bl);
			sl.addActionListener(bl);
			eptext = new JTextField(20);
			eptext.setText("50");
			sltext = new JTextField(20);
			sltext.setText("5");
			
			add(ep);
			add(eptext);
			add(sl);
			add(sltext);
			title.setText("Input All Fields Below");
		}
		validate();
	}
	/**
	 * Clears all the inputs of the text field
	 * @return
	 */
	public void clearInputs(){
		gptext.setText("");
		nostext.setText("");
		lostext.setText("");
		wtext.setText("");
		anftext.setText("");
		
		if(Main.resort){
			eptext.setText("");
			sltext.setText("");
		} else{
			dptext.setText("");
		}
	}

}
