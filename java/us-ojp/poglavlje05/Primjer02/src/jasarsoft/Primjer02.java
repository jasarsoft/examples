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
    }
    
    double stepen1(double x, int n){
        double y = 1;
        for(int i = 0; i < n; i++)
            y *= x; //y = y * x;
        
        return y;
    }
    
    double stepen2(double x, int n){
        if(n == 0)
            return 1;
        else
            return x * stepen2(x, n-1);
    }
}
