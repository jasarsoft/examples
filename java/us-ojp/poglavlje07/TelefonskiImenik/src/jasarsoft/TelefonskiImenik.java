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
public class TelefonskiImenik {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        TelImenik mojImenik = new TelImenik();
        mojImenik.dodajStavku("Pera", null);
        mojImenik.dodajStavku("Pera", "111-1111");
        mojImenik.dodajStavku("Zika", "222-2222");
        mojImenik.dodajStavku("Laza", "333-3333");
        mojImenik.dodajStavku("Mira", "444-4444");
        
        System.out.println("Laza. " + mojImenik.nadjiBroj("Laza"));
        
        mojImenik.dodajStavku("Laza", "999-9999");
        System.out.println("Laza: " + mojImenik.nadjiBroj("Laza"));
        System.out.println("Pera: " + mojImenik.nadjiBroj("Pera"));
        
        mojImenik.ukloniStavku("Zika");
        System.out.println("Zika: " + mojImenik.nadjiBroj("Zika"));
        System.out.println("Mira: " + mojImenik.nadjiBroj("Mira"));
        
    }
    
}
