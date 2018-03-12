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
public class TestGraphicsKomponenta extends JComponent{
    
    public void paintComponent(Graphics g){
        g.drawString("Java je zabavna za programiranje!", 20, 50);
        g.drawRect(50, 80, 150, 50);
    }
}
