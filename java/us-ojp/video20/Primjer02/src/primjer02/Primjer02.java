
package primjer02;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
        List<Pravugaonik> prav = new ArrayList<>();
        
        try {
            FileInputStream fis = new FileInputStream("pravugaonik.dat");
            Scanner s = new Scanner(fis);
            
            while(s.hasNext()) {
                double a = s.nextDouble();
                double b = s.nextDouble();
                s.nextLine();
                
                Pravugaonik p = new Pravugaonik(a, b);
                prav.add(p);
            }
            
            s.close();
            fis.close();
        } catch (FileNotFoundException e) {
            System.out.println("datoteka ne postoji");
        } catch (IOException e) {
            System.out.println("Doslo je do greske priklikom rada sa datotekom.");
        } catch (Exception e) {
            System.out.println("Druga greska.");
        } 
        
        try {
            PrintWriter pw = new PrintWriter("pravougaonici.info");
            
            for (Pravugaonik p : prav) {
                pw.println(p);
                pw.println("Povrsina i obim su: " + p.getPovrsina() + " i " + p.getObim());
            }
            
            pw.flush();
            pw.close();
        } catch (Exception e) {
        }
    }
    
}
