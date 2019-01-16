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
        
        t1.setX(5);
        t1.setY(10);
        
        System.out.println ("T1 x koordinata: " + t1.getX());
        
        System.out.println ("T1: " + t1.toString());
        
        Tacka t2 = new Tacka (2,4);
        System.out.println ("T2: " + t2.toString());
        
        double a = 7;
        Tacka t3 = new Tacka (a);
        System.out.println ("T3: " + t3.toString());
        
        //System.out.println ("Koord pocetak" + Tacka.ORG.toString());
        Tacka.odstampajKoordPoc();
        
        System.out.println ("Rastojanje izmedju tacaka t1 i t2 " + Tacka.rastojanjeIzmedjuTacaka(t1, t2));
        
        Kruznica k1 = new Kruznica (t3,5);
        System.out.println("K1: " + k1.toString());
        
        //promena centra kruznice
        k1.setCentar(t2);
        System.out.println("K1 nakon promene centra: " + k1.toString());
    
        //promena poluprecnika
        k1.setPoluprecnik (10);
        System.out.println("K1 nakon promene r: " + k1.toString());
    
        //dohvatanje poluprecnika
        double r = k1.getPoluprecnik(); 
        
        System.out.println ("Povrsina K1: " + k1.izracunajPovrsinu());
        
        Kruznica k2 = new Kruznica (3,2,7);
        System.out.println ("K2: " + k2.toString());
        
        Kruznica veca = Kruznica.uporediDveKruznice(k1, k2);
        System.out.println ("Veca kruznica je " + veca.toString());
    }
    
}
