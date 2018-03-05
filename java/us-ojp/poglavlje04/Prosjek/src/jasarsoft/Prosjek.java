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

public class Prosjek {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        double broj;        //aktuelni ulazni broj
        double suma;        //suma ulazni brojeva
        int n;              //brojac ulazni brojeva
        double prosjek;     //prosjek ulanzih brojeva
        
        //inicijalizacija sume i brojaca ulaznih brojeva
        suma = 0;
        n = 0;
        
        //ucitavanje, sabiranje i brojanje ulanzih brojeva
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite 1. broj: ");
        
        while (tastatura.hasNextDouble()) { //sljedeci broj je unijet
            broj = tastatura.nextDouble();  //ucitati ga
            suma = suma + broj;             //dodati ga sumi
            n++;                            //uvecati brojac za 1
            System.out.print("Unesite " + (n+1) + ". broj: ");
        }
        
        System.out.println();
        
        if(n == 0)
            System.out.println("GRESKA: unijeto je nula brojeva.");
        else {
            System.out.println("Unijeto je " + n + " brojeva.");
            System.out.println("Porsjek tih brojeva je: " + (suma / n));
        }
    }
    
}
