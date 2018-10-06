
package jasarsoft;

import java.util.Scanner;


public class Primjer04 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unseite ime grada: ");
        
        String imeGrada = s.nextLine();
        
        imeGrada = imeGrada.trim();
        imeGrada = imeGrada.toUpperCase();
        
        if(imeGrada.equals("BEOGRAD") || imeGrada.equals("NOVI SAD")){
            System.out.println("Imamo predstavnistvo u tom gradu");
        } else {
            System.out.println("Zao nam je, ali nemam predstavnistvo u tom gradu");
        }
        
        System.out.println("Program zavrsen!");
    }
    
}
