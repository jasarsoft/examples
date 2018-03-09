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
public class Loto {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        final int n = 39;   //duzina niza svih brojeva
        final int k = 7;    //duzina izvucene kombinacije
        
        //inicijalizacija niza brojevima...
        int[] broj = new int[n];
        for (int i = 0; i < n; i++)
            broj[i] = i + 1;
        
        int m; //granica lijevog i desnog dijela niza
        
        //izvlacenje k brojevima i premjestanje u desni dio niza
        for(m = n-1; m > n-k-1; m--){
            //generisanje slucajnog indeksa lijevog dijela niza
            int i = (int)(Math.random() * (m+1));
            
            //medjusobna zamjena slucajnog elementa i 
            //posljednjeg elementa lijevog dijela niza
            int b = broj[i];
            broj[i] = broj[m];
            broj[m] = b;
        }
        
        //kopiranje izvuceni brojeva u novi niz
        int[] kombinacija = Arrays.copyOfRange(broj, m+1, n);
        
        //sortiranje novog niza
        Arrays.sort(kombinacija);
        
        //prikazivanje izvuceni brojeva u rastucem redosljedu
        System.out.println("Dobitna kombinacija je: ");
        for(int b : kombinacija)
            System.out.print(b + " ");
        
        System.out.println();
    }
    
}
