package datoteka;

import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;

import liste.Radnik;

public class TestUpisUDatoteku {
	
	public static void main (String[] args){
		//Lista klasnog tipa radnik
		ArrayList<Radnik> listaRadnika = new ArrayList<Radnik>();
				
		//dodavanje radnika
		listaRadnika.add(new Radnik ("Pera Peric", 123321, 10, 1000));
				
		Radnik radnik = new Radnik ("Jovan Jovanovic", 1233314, 5, 1500);
		listaRadnika.add(radnik);
		
		listaRadnika.add(new Radnik ("Luka Lukic", 1246434, 7, 1200));
		
		String imeDatoteke = "izlaz.txt";
		
		try {
			PrintWriter printer = new PrintWriter(imeDatoteke);
			//stampanje podataka u datoteku
			printer.println("Broj radnika u listi radnika " + listaRadnika.size());
			printer.println("Radnici u listi " + listaRadnika);
			printer.flush();
			printer.close();
			
			System.out.println("Uspesan upis u datoteku");
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			System.out.println("Greska u radu sa datotekom!!!");
		}
		
		
	}

}
