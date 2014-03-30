package storage;

import java.awt.*;
import java.awt.event.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.swing.*;


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

	}
	
	/**
	 * Resets the output fields
	 */
	
	
	/**
	 * ActionListner that listens for button input
	 *
	 */

				
		
	}

