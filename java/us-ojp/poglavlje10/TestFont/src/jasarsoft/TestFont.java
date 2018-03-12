/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import javax.swing.*;
import java.awt.*;

/**
 *
 * @author jasarsoft
 */
public class TestFont {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        JFrame okvir = new JFrame("Test Font");
        okvir.setSize(500, 300);
        okvir.setLocation(100, 150);
        okvir.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        TestFontKomponenta test = new TestFontKomponenta();
        
        okvir.add(test);
        okvir.setVisible(true);
    }
    
}
