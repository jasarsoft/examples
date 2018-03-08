/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarosft;
import java.util.*;
/**
 *
 * @author jasarsoft
 */
public class Palindrom {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String red;         //ulazni red znakova recenice
        String recenica;    //"sredjen" ulazni red znakova
        Scanner tastatura = new Scanner(System.in);
        
        do{
            System.out.print("Unesite recenicu (<enter> za kraj): ");
            red = tastatura.nextLine();
            
            recenica = sredi(red); //poziv metoda sredi
            System.out.print("Ta recenica ");
            if(recenica.equals(obrni(recenica))) //poziv metoda obrni
                System.out.print("je");
            else
                System.out.print("nije");
            
            System.out.println(" palindrom.");
        } while(red.length() != 0);
    }
    
    public static String sredi(String niska){
        String sredjenaNiska = "";
        
        //konvertovanje svih znakova ulazne niske u mala slova
        niska = niska.toLowerCase();
        
        //zanemarivanje vazeci znakova ulazne niske
        for(int i = 0; i < niska.length(); i++){
            char znak = niska.charAt(i);
            if(Character.isLetterOrDigit(znak))
                sredjenaNiska += znak;
        }
        
        return sredjenaNiska;
    }
    
    public static String obrni(String niska){
        String obrnutaNiska = "";
        
        for(int i = niska.length() - 1; i >= 0; i--){
            obrnutaNiska += niska.charAt(i);
        }
        
        return obrnutaNiska;
    }
}
