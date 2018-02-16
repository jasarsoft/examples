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

public class Primjer09 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner tastatura = new Scanner(System.in);
        
        System.out.print("Unesite string 1: ");
        String s1 = tastatura.nextLine();
        
        System.out.print("Unesite string 2: ");
        String s2 = tastatura.nextLine();
        
        boolean nadjenIstiZnak = false; //s1 i s2 nemaju isti znak
        
        sp: for (int i = 0; i < s1.length(); i++)
                for (int j = 0; j < s2.length(); j++)
                    if (s1.charAt(i) == s2.charAt(j)) { //isti znakovi
                        nadjenIstiZnak = true;
                        break sp;
                    }
    }
    
}
