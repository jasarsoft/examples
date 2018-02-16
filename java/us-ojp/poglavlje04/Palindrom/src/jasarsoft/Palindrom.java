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

public class Palindrom {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner tastatura = new Scanner(System.in);
        String red; //ulazni red znakova recenice
        
        novi_red: do{
            System.out.print("Unesite recenicu (enter za kraj): ");
            red = tastatura.nextLine();
            
            //konvertovanje svih znakova ulaznog reda u mala slova
            red = red.toLowerCase();
            
            //zanemarivanje nevazeci znakova ulanzog reda
            String recenica = "";
            for (int i = 0; i < red.length(); i++){
                char znak = red.charAt(i);
                if (Character.isLetterOrDigit(znak))
                    recenica += znak;
            }
            
            //provjeravanje znakova recenice sa dva kraja
            int l = 0;                      //indeks lijevog znaka
            int d = recenica.length() - 1;  //indeks desnog znaka
            
            while (l < d){ //sve dok se indeksi ne poklapaju
                if (recenica.charAt(l) != recenica.charAt(d)){
                    System.out.println("To nije palindorm.");
                    continue novi_red; //nastavi sa novim ulaznom
                }
                l++; //pomjeri lijevi indeks udesno
                d--; //pomjeri desni indeks ulijevo
            }
            
            System.out.println("To je palindorm.");
        } while (red.length() != 0);
    }
    
}
