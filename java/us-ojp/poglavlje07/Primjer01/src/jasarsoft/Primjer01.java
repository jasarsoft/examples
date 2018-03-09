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
public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
    public static double prosjek1(double... broj){
        double zbir = 0;
        
        for(int i = 0; i <broj.length; i++)
            zbir = zbir + broj[i];
        
        return zbir/broj.length;
    }
    
    public static double prosjek2(double... broj){
        double zbir = 0;
        
        for(double e: broj)
            zbir = zbir + e;
        
        return zbir/broj.length;
    }
}
