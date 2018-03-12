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
public class TestFlowLayout {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //konstruisanje okvira
        JFrame okvir = new JFrame("Test FlowLayout");
        okvir.setSize(300, 200);
        okvir.setLocation(100, 150);
        okvir.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        //konstruisanje set dugmadi
        JButton crvenoDugme = new JButton("Crveno");
        JButton zelenoDugme = new JButton("Zeleno");
        JButton plavoDugme = new JButton("Plavo");
        JButton narandzastoDugme = new JButton("Narandzasto");
        JButton bijeloDugme = new JButton("Bijelo");
        JButton crnoDugme = new JButton("Crno");
        
        //konstruisanje panela za dugmad
        JPanel panel = new JPanel();
        
        //smjestanje dugmadi u panel
        panel.add(crvenoDugme);
        panel.add(zelenoDugme);
        panel.add(plavoDugme);
        panel.add(narandzastoDugme);
        panel.add(bijeloDugme);
        panel.add(crnoDugme);
        
        //smjestanje panela u okvir
        okvir.add(panel);
        okvir.setVisible(true);
    }
    
}
