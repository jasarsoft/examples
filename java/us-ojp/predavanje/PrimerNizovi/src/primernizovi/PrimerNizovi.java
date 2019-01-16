/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primernizovi;

/**
 *
 * @author profesor
 */
public class PrimerNizovi {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int b = 73;
        int[] niz = new int[3];
        niz[0] = 5;
        niz[1] = 5+7;
        niz[2] = b - 17;
        
        System.out.println("Duzina niza = " + niz.length);
        
        for (int i = 0; i < niz.length; i++){
            System.out.println(niz[i]);
        }
        
        niz[2] = 48;
        
        System.out.println ("Drugi clan niza = " + niz[2]);
        
        String[] daniUNedelji = {"ponedeljak", "utorak", "sreda", "cetvrtak", "petak", "subota", "nedelja"};
        System.out.println (daniUNedelji.length);
        
        for (int i = 0; i < daniUNedelji.length; i++){
            System.out.println (daniUNedelji[i]);
        }
        
       
    }
    
}
