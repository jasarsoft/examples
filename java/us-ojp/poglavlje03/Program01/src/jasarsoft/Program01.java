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

public class Program01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int f;  //broj stepeni Faranhajta
        int c;  //broj stepeni Celzijusa
        
        //ulaz programa se dobija preko tastature
        Scanner tastatura = new Scanner(System.in);
        
        //ucitavanje stepena Faranhajta od korisnika
        System.out.print("Koliko stepeni Faranhajta: ");
        f = tastatura.nextInt();
        
        //izracunavanje stepena Celzijusa po formuli
        c = 5 * (f - 32)/9;
        
        //prikazivanje rezultata na ekranu
        System.out.print(f + " stepeni Faranhajta = ");
        System.out.println(c + " stepeni Celzijusa.");
    }
    
}
