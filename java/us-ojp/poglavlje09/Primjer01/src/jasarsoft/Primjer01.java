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
public class Primjer01 {
    enum Dan{
        PONEDJELJAK,
        UTORAK,
        SRIJEDA,
        CETVRTAK,
        PETAK,
        SUBOTA,
        NEDJELJA
    };

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        GodisnjeDoba modnaSezona;
        
        modnaSezona = GodisnjeDoba.LJETO;
        
        if(modnaSezona == GodisnjeDoba.LJETO)
            System.out.println("Krpice za jun, jul i avgust.");
        else
            System.out.println(modnaSezona);
        
        
        System.out.println(modnaSezona);
        
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite godisnje doba: ");
        String g = tastatura.nextLine();
        
        modnaSezona = (GodisnjeDoba)Enum.valueOf(GodisnjeDoba.class, g.toUpperCase());
        System.out.println(modnaSezona);
        
        for(Dan d: Dan.values()){
            System.out.print(d);
            System.out.print(" je dan pod rednim brojem ");
            System.out.println(d.ordinal());
        }
        
        switch(modnaSezona){
            case PROLJECE: //pogresno je GodisnjeDoba.PROLJECE
                System.out.println("Krpcie za mart, april i maj.");
                break;
            case LJETO:
                System.out.println("Krpice za jun, jul i avgust.");
                break;
            case JESEN:
                System.out.println("Krpice za sept, okt i nov.");
                break;
            case ZIMA:
                System.out.println("Krpice za dec, jan i feb.");
                break;
        }
    }
    
}
