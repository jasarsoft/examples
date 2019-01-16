/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primjer01;

import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author jasarsoft
 */
public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite neki tekstulani podatak: ");
        String tekst = s.nextLine();
        
        String imeDatoteke = "izlaz.txt";
        
        try {
            PrintWriter pw = new PrintWriter(imeDatoteke);
            pw.println("Korisnik je unio tekst:");
            pw.println(tekst);
            pw.flush();
            pw.close();
        } catch (FileNotFoundException ex) {
            Logger.getLogger(Primjer01.class.getName()).log(Level.SEVERE, null, ex);
        } 
        
        
    }
    
}
