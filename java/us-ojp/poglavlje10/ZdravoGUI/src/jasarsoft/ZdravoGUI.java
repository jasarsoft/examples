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
public class ZdravoGUI {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String ime = JOptionPane.showInputDialog(null,
                                "Kako se zovete?",
                                "Graficki ulaz",
                                JOptionPane.QUESTION_MESSAGE);
        String godine = JOptionPane.showInputDialog(null,
                                "Koliko imate godina?",
                                "Graficki ulaz",
                                JOptionPane.QUESTION_MESSAGE);
        
        int god = Integer.parseInt(godine);
        
        String poruka = "Zdravo " + ime + "!\n";
        poruka += god + " su najljepse godine";
        
        JOptionPane.showMessageDialog(null, poruka, "Graficki izlaz", JOptionPane.INFORMATION_MESSAGE);
        
        System.exit(0);
    }
    
}
