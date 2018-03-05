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

public class ProstBroj {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        int broj; //ulazni broj
        
        //ucitavanje broja preko tastature
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite cijeli broj veci od 1: ");
        broj = tastatura.nextInt();
        
        int maxDjelioc = (int)Math.sqrt(broj); //maksimalni djelioc
        
        //potraga za djeliocem izmedju 2 i maxDjelioc
        for (int k = 2; k < maxDjelioc; k++){
            if (broj % k == 0) {//da li je broj djeljiv sa k
                System.out.println("Taj broj nije prost.");
                System.out.println("Njegov djelioc je " + k);
                System.exit(0);
            }
        }
        
        System.out.println("Taj broj je prost.");
    }
    
}
