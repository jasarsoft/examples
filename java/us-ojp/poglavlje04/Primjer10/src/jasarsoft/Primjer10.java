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
public class Primjer10 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        int broj = 0; //pocetni broj intervala od 0 do 9
        while (broj < 10) {//ponoviti sve dok je broj manji od 10
            if (broj % 2 != 0) //broj je neparan
                continue; //preskociti ostatak tijela petlje
            
            System.out.print(broj + " "); //prikazati broj na ekranu
            broj = broj + 1; //preci na sljedeci broj
        }
        
        System.out.println(); //pomjeriti kurstor na novi red
    }
    
}
