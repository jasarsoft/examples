/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author jasarsoft
 */
import java.util.*;

public class Zdravo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Kako se zovete: ");
	String ime = tastatura.nextLine();
	System.out.print("Koliko imate godina: ");
	String god = tastatura.nextLine();
	System.out.println("Zdravo " + ime + "!");
	System.out.println(god + " su najljepse godine.");
    }
    
}
