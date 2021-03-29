package HTMLReader;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import javax.swing.*;
import javax.swing.border.Border;

import java.io.*;
import java.net.URL;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.net.MalformedURLException;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;

public class Download extends JPanel {

    private static final String fileName = "freethinkers.html";

    private static final long serialVersionUID = -4469289684986137112L;
    private JTextField addressBar;
    protected static JTextArea console;
    //private JTextArea console;

    public Download(int width, int height) {
	JButton enterButton = new JButton();
	//console = new MyTextArea(100, 100);
	//console.setBackground(new Color(1,1,1, (float) 0.01));
	
	Border border = BorderFactory.createLineBorder(Color.lightGray);
	Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
	setSize(screenSize.width / 2, screenSize.height / 2);
	this.setLocation(screenSize.width / 2 - this.getSize().width / 2, screenSize.height / 2 - this.getSize().height / 2);
	addressBar = new JTextField("Type a URL");
	this.add(addressBar);
	addressBar.setPreferredSize(new Dimension(845, 30));
	addressBar.setBorder(border);
	
	enterButton.setText("GO");
	enterButton.setForeground(Color.RED);
	enterButton.setPreferredSize(new Dimension(60, 30));
	enterButton.setBackground(Color.BLACK);
	enterButton.setBorder(border);
	this.add(enterButton);
	this.setBackground(Color.RED);

	//console = new MyTextArea(910, 700);
	console = new JTextArea();
	console.setEditable(false);
	console.setPreferredSize(new Dimension(910, 700));
	console.setText("Console:");
	console.setBackground(null);
	//JScrollPane jsp = new JScrollPane();
	add(new JScrollPane(console), BorderLayout.CENTER);
	//scrollPane.getViewport().setBackground()
	setVisible(true);
	
	enterButton.addActionListener(new ActionListener() {
	    @Override
	    public void actionPerformed(ActionEvent e) {
		String url = addressBar.getText();
		url = urlFormatter(url);
		addressBar.setText(url);
		DownloadWebPage(url);
	    }
	});

	addressBar.addActionListener(new ActionListener() {
	    public void actionPerformed(ActionEvent e) {
		String url = addressBar.getText();
		url = urlFormatter(url);
		addressBar.setText(url);
		DownloadWebPage(url);
		enterButton.requestFocus();
	    }
	});

	addressBar.addFocusListener(new FocusListener() {
	    @Override
	    public void focusGained(FocusEvent e) {
		addressBar.selectAll();
	    }

	    @Override
	    public void focusLost(FocusEvent e) {

	    }
	});
    }

    private String urlFormatter(String url) {
	if (url.startsWith("https://")) {
	    return url;
	} else if (url.startsWith("www.")) {
	    return "https://" + url;
	} else {
	    return "https://www." + url;
	}
    }

    public static void DownloadWebPage(String webpage) {
	try {
	    URL url = new URL(webpage);
	    BufferedReader reader = new BufferedReader(new InputStreamReader(url.openStream()));
	    BufferedWriter writer = new BufferedWriter(new FileWriter(fileName));
	    Path HTMLpath = Paths.get(fileName);
	    String path = HTMLpath.toString();
	    launchHTML(path);
	    String line;
	    while ((line = reader.readLine()) != null) {
		writer.write(line);
	    }

	    reader.close();
	    writer.close();
	    System.out.println("Successfully Downloaded.");
	    console.setText(console.getText() + '\n' + "Successfully Downloaded.");
	    System.out.println("Launching in browser...");
	}

	catch (MalformedURLException mue) {
	    console.setText("Malformed URL Exception raised");
	    System.out.println("Malformed URL Exception raised");
	} catch (IOException ie) {
	    console.setText("IOException raised");
	    System.out.println("IOException raised");
	}
    }

    public void HTMLParser() {
	Jsoup.parse(fileName, "UTF-8");
    }

    public static void launchHTML(String path) {
	try {
	    java.awt.Desktop.getDesktop().browse(java.net.URI.create(path));
	} catch (IOException e) {
	    console.setText("Error launching in browser.");
	    e.printStackTrace();
	}
    }
    
}
