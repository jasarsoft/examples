package primjer01;

import java.io.PrintWriter;
import java.util.List;

/**
 *
 * @author jasarsoft
 */
public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Milan Tair, 20032313, 13.1.2018.");
        
        List<IndustrijskiRobot> lista = IndustrijskiRobot.load("ulaz.dat");
        
        double suma = 0.0;
        
        for (IndustrijskiRobot ir : lista){
            suma += ir.getEfikasnost();
        }
        
        double srvr = suma / lista.size();
        
        for (int i = 0; i < lista.size(); i++) {
            if (lista.get(i).getEfikasnost() * 1.25 < srvr ||
                    lista.get(i).getEfikasnost() * 0.75 > srvr) {
                lista.remove(i);
                i--;
            }
        }
        
        try {
            PrintWriter pw = new PrintWriter("izlaz.txt");
            
            for (IndustrijskiRobot ir : lista) {
                pw.println(ir);
            }
            
            pw.flush();
            pw.close();
        } catch (Exception e) {
            
            System.out.println("nije moguce raditi sa izlaz.txt datotekom");
        }
    }
    
    
}
