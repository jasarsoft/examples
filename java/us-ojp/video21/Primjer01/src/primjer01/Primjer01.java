package primjer01;

import java.io.FileInputStream;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author jasarsoft
 */
public class Primjer01 {
    
    public static List<Planeta> ucitajPlanete(String imeDatoteke) {
        List<Planeta> lista = new ArrayList<>();
        
        try {
            FileInputStream fis = new FileInputStream(imeDatoteke);
            Scanner s = new Scanner(fis);
            
            while (s.hasNext()) {
                double masa = s.nextDouble();
                double x = s.nextDouble();
                double y = s.nextDouble();
                String ime = s.nextLine();
                
                Planeta p = new Planeta(ime, masa, x, y);
                
                lista.add(p);
            }
            
            s.close();
            fis.close();
        } 
        catch (Exception e) {
            System.out.println("Greska pri ucitavanju");
        }
        
        return lista;
    }
    
    public static Planeta ucitajGlavnuPlanetu(String imeDatoteke) {
        Planeta p = null;
        
        try {
            FileInputStream fis = new FileInputStream(imeDatoteke);
            Scanner s = new Scanner(fis);
            
            double masa = s.nextDouble();
            double x = s.nextDouble();
            double y = s.nextDouble();
            String ime = s.nextLine().trim();
            
            p = new Planeta(ime, masa, x ,y);
            
            s.close();
            fis.close();
        } catch (Exception e) {
            System.out.println("Greska pri ucitavanju planete.");
        }
        
        return p;
    }
    
    public static void sacuvajPlanetu(Planeta p, String imeDatoteke) {
        try {
            PrintWriter pw = new PrintWriter(imeDatoteke);
            pw.println(p);
            pw.flush();
            pw.close();
        } catch (Exception e) {
            System.out.println("Greska pri spremanju planete.");
        }
    }
    
    public static void main(String[] args) {
        List<Planeta> planete = ucitajPlanete("planete.txt");
        Planeta glavna = ucitajGlavnuPlanetu("glavna.txt");
        
        Planeta saNajmanjomSilomPrivlacenja = planete.get(0);
        
        for (Planeta p : planete) {
            if (glavna.getSilaPrivlacenja(p) < glavna.getSilaPrivlacenja(saNajmanjomSilomPrivlacenja)) {
                saNajmanjomSilomPrivlacenja = p;
            }
        }
        
        sacuvajPlanetu(saNajmanjomSilomPrivlacenja, "izabrana.txt");
    }
    
}
