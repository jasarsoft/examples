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

public class Sutra {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //ucitavanje datuma u formatu d m g preko tastature
        System.out.print("Unesite datum u formatu d m g: ");
        Scanner tastatura = new Scanner(System.in);
        int dan = tastatura.nextInt();      //dan datog datuma
        int mjesec = tastatura.nextInt();   //mjesec datog datuma
        int godina = tastatura.nextInt();   //godina datog datuma
        
        //odredjivanje broja dana u aktuelnom mjeecu
        int maxDanaUMjesecu = 0; //ukupan broj dana u datom mjesecu
        
        switch(mjesec){
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                maxDanaUMjesecu = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                maxDanaUMjesecu = 30;
                break;
            case 2:
                if(godina % 4 == 0 && godina % 100 != 0 || godina % 400 == 0)
                    maxDanaUMjesecu = 29;
                else
                    maxDanaUMjesecu = 28;
                break;
            default:
                System.out.println("Pogresan mjesec\n");
                System.exit(0);
        }
        
        //izracunavanje sutrasnjeg datuma
        if(dan < maxDanaUMjesecu)
            dan++;
        else {
            dan = 1;
            if(mjesec < 12)
                mjesec++;
            else {
                mjesec = 1;
                godina++;
            }
        }
        
        //prikazivanje sutrasnjeg datuma na ekrnau
        System.out.print("Sutrasnji datum je: ");
        System.out.println(dan + " " + mjesec + " " + godina);
    }
    
}
