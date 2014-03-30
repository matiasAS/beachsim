package view;

import java.awt.*;
import java.awt.event.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.swing.*;

import control.*;

/**
 * 
 * @author GUI class for the windows
 *
 */
public class Title extends JPanel{
	
	private static final long serialVersionUID = 1L;

	public JLabel title, dash;
	public JButton begin, reset, open, save;
	JFileChooser jfc;
	ButtonListener bl;
	JFrame f;
	JMenuBar menubar;
	public final String dir = "/Users/erjonmalaj/Documents/SkiResortSimulator/";
	
	/**
	 * Constructor for title
	 */
	public Title(){
		title = new JLabel("Beach Simulator");
		begin = new JButton("Begin");
		reset = new JButton("Reset");
		dash = new JLabel("-");
		open = new JButton("Open");
		save = new JButton("Export");
		title.setFont(new Font("comic sans", Font.BOLD, 32));
		title.setForeground(Color.BLUE);
		begin.setFont(new Font("comic sans", Font.CENTER_BASELINE, 14));
		reset.setFont(new Font("comic sans", Font.CENTER_BASELINE, 14));
		open.setFont(new Font("comic sans", Font.CENTER_BASELINE, 14));
		save.setFont(new Font("comic sans", Font.CENTER_BASELINE, 14));

		setLayout(new FlowLayout(FlowLayout.LEFT, 15, 15));
		add(title);
		add(begin);
		add(reset);
		add(dash);
		/*
		add(open);
		*/
		add(save);
		
		bl = new ButtonListener();
		begin.addActionListener(bl);
		reset.addActionListener(bl);
		open.addActionListener(bl);
		save.addActionListener(bl);
	}
	
	/**
	 * Resets the output fields
	 */
	public void reset(){
		begin.setText("Begin");
		Main.b.setButtonsEnabled(false);
		Main.o.setOutputs(-1, 0, 0);
		Main.g.removeAll();
		Main.d.lostext.setEditable(true);
		Main.d.nostext.setEditable(true);
		Logic.s = null;
	}
	
	/**
	 * ActionListner that listens for button input
	 *
	 */
	protected class ButtonListener implements ActionListener {
		public void actionPerformed(ActionEvent e){
			String button = e.getActionCommand();
			try{
				if(button.equalsIgnoreCase("begin") || button.equalsIgnoreCase("run again")){
					if(Main.checkInputs()){
						begin.setText("Run Again");
						Logic.begin();
					} else{
						JOptionPane.showMessageDialog(Main.m, "Incorrectly formatted inputs.");
					}
				} else if(button.equalsIgnoreCase("reset")){
					reset();
					
				} else if(button.equalsIgnoreCase("open")){
					f  = new JFrame("Choose File");
					jfc = new JFileChooser();
					f.setVisible(true);
					jfc.addActionListener(new AbstractAction() {
						private static final long serialVersionUID = 1L;

						public void actionPerformed(ActionEvent evt) {
					        if (JFileChooser.APPROVE_SELECTION.equals(evt.getActionCommand())) {
					        	Logic.loadState(jfc.getSelectedFile().getAbsolutePath());
					        	f.setVisible(false);
					        } else if (JFileChooser.CANCEL_SELECTION.equals(evt.getActionCommand())) {
								f.setVisible(false);
					        }
					    }
					});
					f.add(jfc);
					f.setMinimumSize(new Dimension(400,300));
					f.setResizable(false);
					Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
					f.setLocation(d.width/2-f.getWidth()/2,
								  d.height/2-f.getHeight()/2);
					
					} else{
						if(!Logic.saved){
							String s = (String)JOptionPane.showInputDialog(
				                    null, "Enter Filename: ",
				                    "Save", JOptionPane.PLAIN_MESSAGE, null, null, "first run");
							while(s == null){
								s = (String)JOptionPane.showInputDialog(
					                    null, "Enter Filename: ",
					                    "Save", JOptionPane.PLAIN_MESSAGE, null, null, "first run");
							}
							String ext = ".individual";
							if(Main.resort)
								ext = ".skiresort";
							Logic.saveState(s+ext);
						} else
							Logic.saveState(null);
					}
			} catch(NumberFormatException err){
				JOptionPane.showMessageDialog(Main.m, "Please fill in the missing fields.");
			}
				
		}
	}
}
