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

public class Sort4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
//ucitavanje tri vrijednosti preko tastature
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite tri broja: ");
        int x = tastatura.nextInt();
        int y = tastatura.nextInt();
        int z = tastatura.nextInt();
        
        //prikazivanje sortirani vrijednosti na ekranu
        System.out.print("Rastuci redosljed unijeti brojeva je: ");
        
        if (x > y) { //zamjeniti vrijednost x i y
            int a; //pomocna varijabla
            a = x;
            x = y;
            y = a;
        }
        
        //x je sigurno ispred y
        if(z < x) //z je na prvom mjestu
            System.out.println(z + " " + x + " " + y);
        else if(z > y) //z je na posljednjem mjestu
            System.out.println(x + " " + y + " " + z);
        else //z je usredini
            System.out.println(x + " " + z + " " + y);
    }
    
}
