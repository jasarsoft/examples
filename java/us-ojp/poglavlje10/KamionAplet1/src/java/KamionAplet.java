
import java.awt.BorderLayout;
import java.awt.Font;
import javax.swing.JApplet;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author jasarsoft
 */
public class KamionAplet {
    public void init(){
        
        JApplet okvir = new JApplet();
                
        //JPanel panel = new JPanel();
        
        //Pridruzivanje paostpuka BorderLayout za razmjestanje komponenti
        //u panel sa horizontalnim i vertikalnim  rastojanjem 5 i 10 piksela
        //izmedju njih
        okvir.setLayout(new BorderLayout());
                     
        
        JLabel naslov = new JLabel("KAMION", SwingConstants.CENTER);
        naslov.setFont(new Font("Serif", Font.BOLD, 20));
        okvir.add(naslov, BorderLayout.NORTH);
        
        JComponent fap = new Kamion();
        okvir.add(fap, BorderLayout.CENTER);
        
        //okvir.add(panel);
        //okvir.setVisible(true);
    }
    
}
