/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
/**
 *
 * @author jasarsoft
 */
public class KamionAplet {
    
    public void init(){
        setLayout(new BorderLayout());
        
        JLabel naslov = new JLabel("KAMION", SwingConstants.CENTER);
        naslov.setFont(new Font("Serif", Font.BOLD, 20));
        add(naslov, BorderLayout.NORTH);
        
        JComponent fap = new Kamion();
        add(fap, BorderLayout.CENTER);
    }
}

class Kamion extends JComponent{
    
    public void  paintComponent(Graphics g){
        Graphics2D g2 = (Graphics2D)g;
        
        //bojenje pozadine
        Color blijedoPlava = new Color(0.75F, 0.75F, 1.0F);
        g2.setColor(blijedoPlava);
        g2.fill(new Rectangle2D.Double(0, 0, 300, 200));
        
        //crtanje sasije
        g2.setColor(Color.RED);
        g2.fill(new Rectangle2D.Double(50, 100, 120, 80));
        g2.fill(new Rectangle2D.Double(170, 130, 80, 50));
        
        //crtanje kabine kamiona
        Polygon trougao = new Polygon();
        trougao.addPoint(170, 100);
        trougao.addPoint(170, 130);
        trougao.addPoint(200, 130);
        g2.setColor(Color.yellow);
        g2.fillPolygon(trougao);
        
        //crtanje zadnjeg tocka
        g2.setColor(Color.DARK_GRAY);
        g2.fill(new Ellipse2D.Double(70, 160, 40, 40));
        g2.setColor(Color.WHITE);
        g2.fill(new Ellipse2D.Double(80, 170, 20, 20));
        
        //crtanje prednjeg tocka
        g2.setColor(Color.DARK_GRAY);
        g2.fill(new Ellipse2D.Double(190, 160, 40, 40));
        g2.setColor(Color.WHITE);
        g2.fill(new Ellipse2D.Double(200, 170, 20, 20));
        
        //crtanje logoa na stranici kamiona
        g2.setFont(new Font("Serif", Font.ITALIC, 25));
        g2.setColor(Color.WHITE);
        g2.drawString("Java", 70, 125);
        g2.drawString("prevoznik", 70, 150);
    }
}
