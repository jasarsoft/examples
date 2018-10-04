
package jasarsoft;

import java.util.Scanner;

public class Primjer04 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite x i y vrijednosti: ");
        double x = s.nextDouble();
        double y = s.nextDouble();
        
        double f = x * y /(1-x) + 3;
        
        System.out.println("F(x, y) = " + f);
    }
    
}
