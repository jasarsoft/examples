/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.util.*;
/**
 *
 * @author jasarsoft
 */
public class PogadjanjeBroja {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String ponovo; //indikator nastavka igre
        Scanner tastatura = new Scanner(System.in);
        
        System.out.println("Ovo je igra pogadjanja broja.");
        System.out.println("Ja cu zamisliti broj izmedju 1 i 100,");
        System.out.println("a vi treba da ga pogodite.\n");
        
        do{
            pogodiBroj(); //poziv metoda za jedno pogadjanje broja
            System.out.print("Zelite li da ponovo igrate (d/n)? ");
            ponovo = tastatura.next();
        } while (ponovo.equals("d"));
        
        System.out.println("Hvala i do vidjenja...");
    }
    
    public static void pogodiBroj(){
        int zamisljenBroj; //broj koji je racunar izabrao
        int pokusanBroj;    //broj koji je korisnik pokusao
        
        Scanner tastatura = new Scanner(System.in);
        zamisljenBroj = (int)(100*Math.random()) + 1;
        System.out.println("Zamislio sam cio broj izmedju 1 i 100.");
        System.out.println("Pokusajte da ga pogodite.\n");
        
        do{
            System.out.print("Pogodite broj> ");
            pokusanBroj = tastatura.nextInt();
            if(pokusanBroj < zamisljenBroj)
                System.out.println("Zamislio sam veci broj!");
            else if(pokusanBroj > zamisljenBroj)
                System.out.println("Zamislio sam manji broj!");
            else
                System.out.println("Bravo, pogodili ste broj!");
        } while (pokusanBroj != zamisljenBroj);
    }
}
