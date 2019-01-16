/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerklase;

/**
 *
 * @author profesor
 */
public class PrimerKlase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Tacka t1 = new Tacka();
        System.out.println ("T1: " + t1.toString());
        
        t1.x = 5;
        t1.y = 10;
        
        System.out.println ("T1: " + t1.toString());
        
        Tacka t2 = new Tacka (2,4);
        System.out.println ("T2: " + t2.toString());
        
        double a = 7;
        Tacka t3 = new Tacka (a);
        System.out.println ("T3: " + t3.toString());
        
        //System.out.println ("Koord pocetak" + Tacka.ORG.toString());
        Tacka.odstampajKoordPoc();
        
        System.out.println ("Rastojanje izmedju tacaka t1 i t2 " + Tacka.rastojanjeIzmedjuTacaka(t1, t2));
    }
    
}
