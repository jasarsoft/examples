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
        Radnik[] spisakRadnik = new Radnik[3];
        
        spisakRadnik[0] = new Radnik();
        spisakRadnik[1] = new Radnik();
        spisakRadnik[2] = new Radnik();
        
        Arrays.sort(spisakRadnik);
    }
    
}
