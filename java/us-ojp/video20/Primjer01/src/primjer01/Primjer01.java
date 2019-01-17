package primjer01;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Primjer01 {

    public static void main(String[] args) {
        try {
            FileInputStream fis = new FileInputStream("ulaz.txt");
            Scanner s = new Scanner(fis);
            
            String ime = s.nextLine();
            String prezime = s.nextLine();
            String indeks = s.nextLine();
            String kategorija = s.nextLine();
            
            s.close();
            fis.close();
            
            System.out.println("Ime je " + ime + " " + prezime);
            System.out.println("Indeks i kategorija su " + indeks + " i " + kategorija);
        } catch(FileNotFoundException e) {
          System.out.println("Ta datoteka ne postoji.");
        } catch (Exception e) {
            System.out.println("Doslo je do neke greske prilikom rada sa datotekom.");
        }
    }
    
}
