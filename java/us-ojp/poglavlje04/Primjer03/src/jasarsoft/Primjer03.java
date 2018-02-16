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
public class Primjer03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        int broj = 0;           //pocetni broj koji se prikazuje
        while (broj < 10){      //ponoviti sve dok je broj manji od 10
            System.out.print(broj + " ");   //prikazati broj na ekranu
            broj = broj + 1;                //preci na sljedeci broj
        }
        
        System.out.println(); //pomjeriti kursor na novi red
    }
    
}
