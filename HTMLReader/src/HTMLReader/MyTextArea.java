package HTMLReader;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.nio.file.Path;
import java.nio.file.Paths;

import javax.imageio.ImageIO;
import javax.swing.JTextArea;


public class MyTextArea extends JTextArea {

    private static final long serialVersionUID = -1294790904246368454L;
    private Image img;

    public MyTextArea(int a, int b) {
	super(a, b);
	try {
	    img = ImageIO.read(new File("BestCountryEver.jpg"));
	} catch (IOException e) {
	    System.out.println(e.toString());
	}
    }
    /*
     * @Override public void paintComponent(Graphics g) { super.paintComponent(g);
     * 
     * try { BufferedImage image =
     * ImageIO.read(HTMLReader.class.getResource("/HTMLReader/BestCountryEver.jpg"))
     * ; g.drawImage(image, 0, 0, this); } catch (IOException ioe) {
     * System.out.println("You fool. You absolute baffoon"); } }
     */

}