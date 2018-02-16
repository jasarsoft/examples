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

public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite broj: ");
        int n = tastatura.nextInt();
        
        if(n % 2 == 0)  //n je paran broj
            System.out.println("n je paran broj");
        else
            System.out.println("n je neparan broj");
        
        System.out.println("n = " + n);
    }
    
}
