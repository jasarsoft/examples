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
public class Primjer04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        System.out.println("Fibonacijev niz za 10 je: " + fib(10));
    }
    
    static int fib(int n){
        
        if(n <= 2) //bazni slucaj
            return 1;
        else
            return fib(n-1) + fib(n-2);
    }
}
