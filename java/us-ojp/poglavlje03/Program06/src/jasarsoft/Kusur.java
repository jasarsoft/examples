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

public class Kusur{

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int iznos;              //dati iznos za usitnjavanje
        int n25, n10, n5, n1;   //broj novcica usinjenog iznosa
        
        //ulaz programa se dobija preko tastautre
        Scanner tastatura = new Scanner(System.in);
        
        //ucitavanje novcanog iznosa za usitnjavanje
        System.out.print("Unesite iznos za usitnjavanje: ");
        iznos = tastatura.nextInt();
        
        //izracunavanje brojeva novcica usitenjnog iznosa
        n25 = iznos / 25;       //broj novica vrijednosti 25
        iznos = iznos % 25;     //preostali iznos za usitnjavanje
        n10 = iznos /10;        //broj novica vrijednosti 10
        iznos = iznos % 10;     //preostali iznos za usitnjavanje
        n5 = iznos / 5;         //broj novica vrijednosti 5
        n1 = iznos % 5;         //broj novica vrijednosti 1
        
        //prikazivanje rezultata na ekranu
        System.out.print("Minimalni broj novica za ");
        System.out.println("dati iznos je: ");
        System.out.println(n25 + " novcica vrijednosti 25.");
        System.out.println(n10 + " novica vrijednosti 10.");
        System.out.println(n5 + " novica vrijednosti 5.");
        System.out.println(n1 + " novica vrijednosti 1.");
    }
    
}
