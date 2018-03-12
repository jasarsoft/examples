/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import javax.swing.JOptionPane;

/**
 *
 * @author jasarsoft
 */
public class TestDugmeBrojac3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        DugmeBrojacOkvir okvir = new DugmeBrojacOkvir();
        okvir.setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        
        //pridruzivanje rukovaoca dogadjaja zatvaranja okvira
        okvir.addWindowListener(new WindowAdapter(){
            public void windowClosing(WindowEvent e){
                Object[] opcija = {"Da", "Ne"};
                int izabranaOpcija = JOptionPane.showOptionDialog(null,
                        "Zaista zelite da zavrsite program?",
                        "Kraj rada programa",
                        JOptionPane.DEFAULT_OPTION,
                        JOptionPane.WARNING_MESSAGE,
                        null, opcija, opcija[0]);
                
                if(izabranaOpcija == 0)
                    System.exit(0);
            }
        });
        
        
        okvir.setVisible(true);
    }
    
}

//glavni okvir sa dugmetom i oznakom
class DugmeBrojacOkvir extends JFrame{
    private JLabel oznaka; //oznaka u okviru
    
    //konstruktor
    public DugmeBrojacOkvir(){
        setTitle("Brojanje pritiska na dugme");
        setSize(300, 150);
        setLayout(new FlowLayout(FlowLayout.CENTER, 30, 20));
        
        oznaka = new JLabel("Broj pritisaka = 0");
        add(oznaka);
        JButton dugme = new JButton("Pritisni me");
        add(dugme);
        
        //dodavanje objekta za rukovanje dogadjajem dugmeta
        dugme.addActionListener(new ActionListener(){
            //aninimna klasa koja implementira ActionListener
            private int brojac; //brojac pritiska na dugme
            
            public void actionPerformed(ActionEvent e){
                brojac++;
                oznaka.setText("Broj pritiska = " + brojac);
            }
        });
    }
}