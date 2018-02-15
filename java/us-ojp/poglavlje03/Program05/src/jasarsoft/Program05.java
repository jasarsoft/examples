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
import java.lang.Double;

public class Program05 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Double d = new Double(5.220931);
        
        double x = d.doubleValue() * 3.14;
        System.out.println(x);
        
        Integer broj = 32;
        Integer broj2 = new Integer(32);
        System.out.println(broj.intValue());
        System.out.println(broj2.intValue());
    }
    
}
