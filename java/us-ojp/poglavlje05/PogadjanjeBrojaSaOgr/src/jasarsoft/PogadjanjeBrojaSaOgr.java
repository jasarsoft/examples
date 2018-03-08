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
public class PogadjanjeBrojaSaOgr {
    
    static int brojPogodaka = 0; //brojac pogodjeni brojeva
    final static int MAX_BROJ_POKUSAJA = 5; //najveci broj pokusaja
    static Scanner tastatura = new Scanner(System.in);
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String ponovo;
        
        System.out.println("Ovo je igra pogadjanja broja.");
        System.out.println("Ja cu zamisliti broj izmedju 1 i 100.");
        System.out.print("a vi treba da pogodite iz ");
        System.out.println(MAX_BROJ_POKUSAJA + " puta.\n");
        
        do{
            pogodiBroj();
            System.out.print("Zelite li da ponov igrate (d/n)? ");
            ponovo = tastatura.next();
        } while(ponovo.equals("d"));
        
        System.out.print("Pogodili ste ");
        if(brojPogodaka == 1)
            System.out.println("jedanput.");
        else
            System.out. println(brojPogodaka + " puta.");
        
        System.out.println("Hvala i dovidjenja...");
    }
    
    public static void pogodiBroj(){
        int zamisljenBroj;      //broj koji je racunar zamislio
        int pokusanBroj;        //broj koji je korisnik pokusao
        int brojPokusaja;       //brojac pokusaja korisnika
        
        brojPokusaja = 0;
        zamisljenBroj = (int)(100 * Math.random()) + 1;
        
        System.out.println("Zamislio sam cjeli broj izmedju 1 i 100.");
        System.out.println("Pokusajte da ga pogodite.\n");
        
        for(;;){ //beskonacna petlja
            System.out.print("Pogodite broj> ");
            pokusanBroj = tastatura.nextInt();
            brojPokusaja++;
            
            if(pokusanBroj == zamisljenBroj){
                System.out.println("Bravo, pogodili ste broj.");
                brojPogodaka++;
                break;
            }
            else if (brojPokusaja == MAX_BROJ_POKUSAJA){
                System.out.print("Niste pogodili broj iz ");
                System.out.println(MAX_BROJ_POKUSAJA + " puta.");
                System.out.print("Zamislio sam broj " + zamisljenBroj);
                break;
            }
            else if (pokusanBroj < zamisljenBroj)
                System.out.println("Zamislio sam veci broj.");
            else if(pokusanBroj > zamisljenBroj)
                System.out.println("Zamislio sam manji broj.");
            else{
                System.out.println("Ovaj slucaj nije moguc.");
                break;
            }
        }
    }
}
