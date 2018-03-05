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

public class Stednja {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        double stanje;      //akumulirani iznos stednje
        double kamatnaStopa;//godisnja kamatna stopa na stednju
        int period;         //broj godina za izvjestaj
        
        //ucitavanje pocetnog depozita, kamate i perioda izvjestaja
        Scanner tastatura = new Scanner(System.in);
        
        System.out.print("Unesite pocetni depozit: ");
        stanje = tastatura.nextDouble();
        
        System.out.print("Unesite godisnju kamatu: ");
        kamatnaStopa = tastatura.nextDouble();
        
        System.out.print("Unesite broj godina izvjestavja: ");
        period = tastatura.nextInt();
        
        //prikazivanje akumulirane stednje nakon svake godine
        int godina = 1; //godina za koju se prikazuje stednja
        
        while(godina <= period){
            //izracunavanje kamate za ovu godinu
            double kamata = stanje * kamatnaStopa;
            
            //dodavanje kamate na predhodno stanje
            stanje = stanje + kamata;
            
            //prikazivanje novog stanje
            System.out.print("Stednja nakon " + godina + " iznosi €");
            System.out.printf("%1.2f\n", stanje);
            
            //sljedeca godina izvjestaja
            godina++;
        }
    }
    
}
