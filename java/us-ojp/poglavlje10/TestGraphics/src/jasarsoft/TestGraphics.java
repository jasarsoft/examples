/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import javax.swing.*;
/**
 *
 * @author jasarsoft
 */
public class TestGraphics {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //konstruisanje okvira
        JFrame okvir = new JFrame("Test Graphic");
        okvir.setSize(300, 200);
        okvir.setLocation(100, 150);
        okvir.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        //konstruisanje komponenete
        TestGraphicsKomponenta komp = new TestGraphicsKomponenta();
        
        //smjestanje komponente u okvir
        okvir.add(komp);
        okvir.setVisible(true);
    }
    
}
