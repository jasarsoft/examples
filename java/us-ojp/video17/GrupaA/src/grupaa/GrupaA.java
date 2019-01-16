
package grupaa;

import java.util.Scanner;

/**
 *
 * @author jasarsoft
 */
public class GrupaA {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Milan Tair, 2008330300, 10.11.2016.");
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Koliko telefona zelite da unesete? ");
        int broj = s.nextInt();
        if (broj < 1) {
            System.out.println("nije ispravan broj koji ste unijeli.");
            return;
        }
        
        MobilniTelefoni[] niz = new MobilniTelefoni[broj];
        
        for (int i = 0; i < broj; i++) {
            System.out.print("Unesite ime proizvodjaca: ");
            String proizvodjac = s.nextLine();
            
            System.out.print("Unesite naziv modela: ");
            String model = s.nextLine();
            
            System.out.print("Unesite godinu proizodnje: ");
            int godinaProizvodnje = s.nextInt();
            if (godinaProizvodnje < 1990 || godinaProizvodnje > 2016) {
                System.out.println("Nije ispravna godina prozivodnje");
                return;
            }
            
            System.out.print("Unesite kolicinu RAM memorije: ");
            int kolicnaRAM = s.nextInt();
            if (kolicnaRAM < 1024) {
                System.out.println("Ne razmatramo te telefone.");
                return;
            }
            
            System.out.print("Unesite kolicinu DISK memorije: ");
            int kolicnaDisk = s.nextInt();
            if (kolicnaDisk < 2048) {
                System.out.println("Ne razmatramo te telefone.");
                return;
            }
            
            System.out.print("Unesite sirinu ekrana u incima: ");
            double sirina = s.nextDouble();
            if (sirina < 2.0 ){
                System.out.println("Ne razmatramo ttakve uredjaje.");
                return;
            }
            
            System.out.print("Unesite visinu ekrana u incima: ");
            double visina = s.nextDouble();
            if (visina < 2.0 ){
                System.out.println("Ne razmatramo ttakve uredjaje.");
                return;
            }
            
            niz[i] = new MobilniTelefoni(proizvodjac, model, godinaProizvodnje, kolicnaRAM, kolicnaDisk, new EkranTelefona(sirina, visina));
        }
        
        sortiraj(niz);
    }
    
    public static void sortiraj(MobilniTelefoni[] niz) {
        for (int j = 0; j < niz.length - 1; j++) {
            for (int i = 0; i < niz.length - 1; i++){
                if (niz[i].ocjenaPodobnosti() < niz[i+1].ocjenaPodobnosti()) {
                    MobilniTelefoni.zamjeniMjesto(niz[i], niz[i+1]);
                }
            }
        }
    }
}
