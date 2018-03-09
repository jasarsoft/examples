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
public class BacanjeDvijeKocke {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int brojBacanja = 0;                        //brojac bacanja dvije kocke
        KockaZaIgru kocka1 = new KockaZaIgru();     //prva kocka
        KockaZaIgru kocka2 = new KockaZaIgru();     //druga kocka
        
        do{
            kocka1.baci();
            System.out.print("Na prvoj kocki je pao broj: ");
            System.out.println(kocka1.broj);
            
            kocka2.baci();
            System.out.print("Na drugoj kocki je pao broj: ");
            System.out.println(kocka2.broj);
            
            brojBacanja++;                          //uracunati bacanje
        } while(kocka1.broj != kocka2.broj);
        
        System.out.print("Dvije kocke su bacene " + brojBacanja);
        System.out.println(" puta pre nego sto je pao isti broj.");
    }
    
}
