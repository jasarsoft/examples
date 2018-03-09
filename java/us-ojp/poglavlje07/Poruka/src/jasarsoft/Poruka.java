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
public class Poruka {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        if(args[0].equals("-d"))
            System.out.print("Dobar dan");
        else if(args[0].equals("-z"))
            System.out.print("Zbogom");
        
        //prikazi ostale argumente u komandom redu
        for(int i = 1; i < args.length; i++)
            System.out.print(" " + args[i]);
        
        System.out.println("!");
    }
    
}
