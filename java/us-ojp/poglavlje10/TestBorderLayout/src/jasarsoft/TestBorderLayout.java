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
public class TestBorderLayout {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //konsttrusianje okvira
        JFrame okvir = new JFrame("Test BorderLayout");
        okvir.setSize(300, 200);
        okvir.setLocation(100, 150);
        okvir.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        //konstruisanje pet dugmadi
        JButton istocnoDugme = new JButton("Istocno");
        JButton zapadnoDugme = new JButton("Zapadno");
        JButton sjevernoDugme = new JButton("Sjeverno");
        JButton juznoDugme = new JButton("Juzno");
        JButton centralnoDugme = new JButton("Centralno");
        
        //konstruisanje panela za dugmad
        JPanel panel = new JPanel();
        
        //Pridruzivanje paostpuka BorderLayout za razmjestanje komponenti
        //u panel sa horizontalnim i vertikalnim  rastojanjem 5 i 10 piksela
        //izmedju njih
        panel.setLayout(new BorderLayout(5, 10));
        
        //smjestanje dugmadi u panel
        panel.add(istocnoDugme, BorderLayout.EAST);
        panel.add(zapadnoDugme, BorderLayout.WEST);
        panel.add(sjevernoDugme, BorderLayout.NORTH);
        panel.add(juznoDugme, BorderLayout.SOUTH);
        panel.add(centralnoDugme, BorderLayout.CENTER);
        
        //smjestanje panela u okvir
        okvir.add(panel);
        okvir.setVisible(true);
    }   
}
