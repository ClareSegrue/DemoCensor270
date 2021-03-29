package HTMLReader;

import java.awt.BorderLayout;
import java.awt.Color;

import javax.swing.JFrame;

public class Driver {
    private final Download download;
   
    public static void main(String[] args) {
	new Driver();
    }
    
    public Driver() {
	final JFrame app = new JFrame();
	app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	app.setLayout(new BorderLayout());
	download = new Download(0, 0);
	app.setVisible(true);
	app.add(download);
	app.setForeground(Color.RED);
	app.setSize(950, 800);
	app.setLocationRelativeTo(null);
	app.setResizable(false);
	app.setTitle("Company Co. Browser");
    }

}
