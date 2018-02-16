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
public class Primjer06 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        for (int n = 0, m = 9; n < 10; n++, m--){
        System.out.printf("%5d", n);        //kolona sirine 5 mjesta za n
        System.out.printf("%5d", m);        //kolona sirine 5 mjesta za m
        System.out.println();               //prelazak u novi red
        }
    }
    
}
