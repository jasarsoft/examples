/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.util.*;
/**
 *
 * @author jasarsoft
 */
public class ProstBroj {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int broj; //ulazni broj
        
        //ucitavanje broja preko tastature
        Scanner tastatura = new Scanner(System.in);
        
        System.out.println("Ovo je program koji odreduje da li je broj prost.");
        System.out.print("Unesite broj veci od 1 (0 za kraj): ");
        broj = tastatura.nextInt();
        
        while(broj != 0){
            System.out.print("Taj broj ");
            if (jeProst(broj)) //poziv metoda
                System.out.print("je ");
            else
                System.out.print("nije ");
            
            System.out.print("prost.");
            
            System.out.print("Uniste broj veci od 1 (0 za kraj): ");
            broj = tastatura.nextInt();
        }
    }
    
    public static boolean jeProst(int n){
        int maxDjelioc = (int)Math.sqrt(n); //maksimalni djelioc
        
        //potraga za djeliocem izmedju 2 i maxDjelioc
        for (int k = 2; k < maxDjelioc; k++){
            if(n % k == 0)
                return false;
        }
        
        return true;
    }
}
