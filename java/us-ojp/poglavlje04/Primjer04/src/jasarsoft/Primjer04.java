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

public class Primjer04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        int zamisljeniBroj;     //broj koji je racunar izbarao
        int pokusanBroj;        //broj koji je korisnik pokusao
        boolean pogodak;        //indikator da li je korisnik pogodio
        
        Scanner tastatura = new Scanner(System.in);
        
        zamisljeniBroj = (int)(100 * Math.random() + 1);
        pogodak = false; //broj nije pogodjen na pocetku
        
        System.out.println("Zamislio sam cijeli broj izmedju 1 i 100.");
        System.out.println("Pokusajte da ga pogodite.\n");
        
        do {
            System.out.print("Pogodite broj: ");
            pokusanBroj = tastatura.nextInt();
            
            if(pokusanBroj < zamisljeniBroj)
                System.out.println("Zamislio sam vec broj :-(");
            else if (pokusanBroj > zamisljeniBroj)
                System.out.println("Zamislio sam manji broj :-(");
            else
                System.out.println("Bravo, pogodili ste broj :-)");
        } while (pokusanBroj != zamisljeniBroj);
    }
    
}
