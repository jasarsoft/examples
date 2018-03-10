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
public class Primjer02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Ucenik u = new Ucenik("Laza Lazic", 16, "gimnazija", 2);
        
        Dijete mojeDijete = new Dijete("Aca", 10);
        System.out.print("Moj mali je " + mojeDijete);
        System.out.println(", ljubi ga majka.");
    }
    
}
