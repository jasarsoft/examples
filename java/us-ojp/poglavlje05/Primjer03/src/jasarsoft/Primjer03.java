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
public class Primjer03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("Najmanji zajednicki djeliclac za 9 i 6");
        System.out.println(nzd(9, 6));
    }
    
    static int nzd(int x, int y){
        
        if (x % y == 0) //bazni slucaj
            return y;
        else
            return nzd(y, x % y);
    }
}
