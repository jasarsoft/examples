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
public class ProfitFirme {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.print("Program za rad sa tebelom profita koji ");
        System.out.print("je ostvarilo 10 prodavnica firme za 12 mjeseci.\n");
        
        Firma abc = new Firma(10);   //firma sa 10 prodavnica
        Scanner tastatura = new Scanner(System.in);
        int brojOpcije;
        
        do{
            prikaziMeni();
            brojOpcije = tastatura.nextInt();
            
            switch(brojOpcije){
                case 1:
                    abc.unesiProfit();
                    break;
                case 2:
                    abc.prikaziProfit();
                    break;
                case 3:
                    if(abc.getProfit() == null)
                        System.out.println("Greska: podaci nisu unijeti!");
                    else
                        System.out.print("Ukupni godisnji profit firme: ");
                    
                    System.out.printf("%8.2f", abc.godisnjiProfit());
                    System.out.println();
                    break;
                case 4:
                    abc.prikaziProfitPoMjesecima();
                    break;
                case 5:
                    abc.prikaziProfitPoProdavnicama();
                    break;
                case 0:
                    System.out.println("Kraj programa...");
                    break;
                default:
                    System.out.println("Greska: pogresna opcija!");
            }
            
        }while(brojOpcije != 0);
    }
    
    private static void prikaziMeni()
    {
        System.out.println();
        System.out.println("Izaberite opciju:");
        System.out.println(" 1. unos tabele profita");
        System.out.println(" 2. prikaz tabele profita");
        System.out.println(" 3. prikaz ukunog godisnjeg profita");
        System.out.println(" 4. prikaz profita po mjesecim");
        System.out.println(" 5. prikaz profita po prodavnicama");
        System.out.println(" 0. kraj rada");
        System.out.print("Unesite broj opcije: ");
    }
}
