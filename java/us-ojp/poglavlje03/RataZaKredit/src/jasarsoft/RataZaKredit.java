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

public class RataZaKredit {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //ulaz programa se dobija preko tastature
        Scanner stdin = new Scanner(System.in);
        
        //ucitavanje kredita, kamate i broja rata
        System.out.print("Iznos kredita: ");
        double p = stdin.nextDouble();
        System.out.print("Godisnja kamata: ");
        double k = stdin.nextDouble();
        System.out.print("Broj mjesecni rata: ");
        int m = stdin.nextInt();
        
        //izracunavanje mjesecne rate
        double mk = k / 12; //mjesecna kamata
        double aNaM = Math.pow(1 + mk, m);
        double r = (p + aNaM * mk) / (aNaM - 1);
        
        //prikazivanje rezultata na ekranu
        System.out.println("Mjesecna rata: " + r);
    }
    
}
