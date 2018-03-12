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
public class TestFontKomponenta extends JComponent {
    
    public void paintComponent(Graphics g){
        Graphics2D g2 = (Graphics2D)g;
        
        Font sansBold36 = new Font("SansSerif", Font.BOLD, 36);
        g2.setFont(sansBold36); //veliki font za tekst
        g2.drawString("Zdravo narode!", 50, 50);
        
        Font serifPlain18 = new Font("Serif", Font.PLAIN, 18);
        g2.setFont(serifPlain18);   //manji font za tekst
        g2.setPaint(Color.RED);     //crvena boja za crtanje
        g2.drawString("Java je zapavna za programirnje", 80, 100);
    }
}
