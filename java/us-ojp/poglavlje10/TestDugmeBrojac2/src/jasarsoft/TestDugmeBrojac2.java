/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
/**
 *
 * @author jasarsoft
 */
public class TestDugmeBrojac2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        DugmeBrojacOkvir okvir = new DugmeBrojacOkvir();
        okvir.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
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