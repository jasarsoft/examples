package datoteka;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class TestCitanjeIzDatoteke {
	
	public static void main (String[] args){
		
		try {
			FileInputStream fis = new FileInputStream("ulaz.txt");
			Scanner skener = new Scanner (fis);
			
			ArrayList<Radnik> lista = new ArrayList<Radnik>();
			
			while (skener.hasNext()){
				String ime = skener.nextLine().trim();
				long id = skener.nextLong();
				int staz = skener.nextInt();
				double plata = skener.nextDouble();
				skener.nextLine();
				
				lista.add(new Radnik (ime, id, staz, plata));
				
			}
			
			System.out.println("Lista radnika: " + lista);
			
			skener.close();
			fis.close();
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Greska u citanju datoteke");
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Greska u citanju datoteke");
		}
		
	}

}
