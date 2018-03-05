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

public class TablicaMnozenja {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        for (int brojReda = 1; brojReda < 10; brojReda++){
            for (int brojKolone = 1; brojKolone < 10; brojKolone++)
                System.out.printf("%4d", brojReda * brojKolone);
            System.out.println(); //preci u novi red na ekranu
        }
    }
    
}
