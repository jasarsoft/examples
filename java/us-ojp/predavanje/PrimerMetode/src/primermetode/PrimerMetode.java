/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primermetode;

import java.util.Scanner;

/**
 *
 * @author profesor
 */
public class PrimerMetode {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int x,y;
        System.out.println ("Uneti dva broja");
        
        Scanner tastatura = new Scanner (System.in);
        x = tastatura.nextInt();
        y = tastatura.nextInt();
        
        //ispis zbira dva broja
        System.out.println("Zbir unetih brojeva je = " + zbirDvaBroja(x,y));
        //ispis proizvoda dva broja
        System.out.println("Proizvod unetih brojeva je = " + proizvodDvaBroja(x,y));
        double c = izracunavanjeHipotenuze(x,y);
        System.out.println("Hipotenuza = " + c);
        double d = izracunavanjeHipotenuze(10, 15);
        
        int e = zbirDvaBroja(10, proizvodDvaBroja(2,3));
        
        System.out.println(ponavljanjeStringa("cao",3));
        String b = ponavljanjeStringa ("abc", 4);
        b.length();
    }
    
    public static int zbirDvaBroja (int broj1, int broj2){
        return broj1+broj2;
    }
    
    public static int proizvodDvaBroja (int x, int y){
        return x * y;
    }
    
    //sqrt (a^2 + b^2)
    public static double izracunavanjeHipotenuze (int a, int b){
        return Math.sqrt(Math.pow(a,2) + Math.pow(b,2));
    }
    
    public static String ponavljanjeStringa(String a, int b){
        String rezultat = "";
        for (int i = 0; i < b; i++){
            rezultat += a;
        }
        return rezultat;
    }
    
    
    
    
    
}
