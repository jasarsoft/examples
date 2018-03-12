
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Polygon;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Rectangle2D;
import javax.swing.JComponent;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author jasarsoft
 */
public class Kamion extends JComponent{
    
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
