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
public class HanojskeKule {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int n; //broj diskova
        
        Scanner tastatura = new Scanner(System.in);
        
        System.out.print("Unesite broj diskova Hanojskih kula> ");
        n = tastatura.nextInt();
        
        System.out.println();
        System.out.println("Rjesenje igre za taj broj diskova je:");
        
        premjestiDiskove(n, 'A', 'B', 'C');
    }
    
    
    static void premjestiDiskove(int n, char a, char b, char c){
        
        if (n == 1) //bazni slucaj
            premjestiDisk(a, c);
        else{
            premjestiDiskove(n-1, a, c, b);
            premjestiDisk(a, c);
            premjestiDiskove(n-1, b, a, c);
        }
    }
    
    static void premjestiDisk(char x, char y){
        System.out.print("Disk na vrhu stuba " + x);
        System.out.println(" premjesti na vrh stuba " + y);
    }
}