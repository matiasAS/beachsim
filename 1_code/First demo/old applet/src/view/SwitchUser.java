package view;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 * GUI Class which handles the mode switch to Individual and the Resort and vice-versa
 * @author
 *
 */
public class SwitchUser extends JPanel{

	private static final long serialVersionUID = 1L;

	JLabel text;
	JButton skiresort;
	JButton individual;
	ButtonListener bl;
	
	/**
	 * Constructor for SwitchUser
	 */
	public SwitchUser() {
		super();
		text = new JLabel("Switch to: ");
		skiresort = new JButton("Ski Resort");
		skiresort.setForeground(Color.RED);
		individual = new JButton("Individual");
		
		bl = new ButtonListener();
		skiresort.addActionListener(bl);
		individual.addActionListener(bl);
		
		setLayout(new FlowLayout(FlowLayout.LEFT));
		/*
		add(text);
		add(skiresort);
		add(individual);*/
	}

	/**
	 * ActionListner that listens for button input
	 */
	protected class ButtonListener implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent arg0) {
			String command = arg0.getActionCommand();
			
			if(command.equalsIgnoreCase("individual")){
				if(Main.resort){
					Main.resort = !Main.resort;
					Main.d.switchuser(true);
					Main.b.switchuser(true);
					individual.setForeground(Color.RED);
					skiresort.setForeground(Color.BLACK);
					Main.t.reset();
				}
			} else{
				if(!Main.resort){
					Main.resort = !Main.resort;
					Main.d.switchuser(false);
					Main.b.switchuser(false);
					individual.setForeground(Color.BLACK);
					skiresort.setForeground(Color.RED);
					Main.t.reset();
				}
			}
		}
		
	}
	
}
