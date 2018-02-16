/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;

/**
 *
 * @author jasarsoft
 */
import java.util.*;

public class Primjer02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite poluprecnik: ");
        double r = tastatura.nextDouble();
        
        if(r <= 0)
            System.out.println("Greska: poluprecnik nije pozitivan.");
        else {
            double obim = 2 * r * Math.PI;
            System.out.print("Obum kruga tog poluprecnika ");
            System.out.println("je: " + obim);
        }
    }
    
}
