import java.util.Scanner;


public class FarCel {

	public static void main (String [] args){
		int f;	//broj stepeni Farenhajta
		int c;	//broj stepeni Celzijusa
		
		//Ulaz programa se dobija sa tastature
		Scanner tastatura = new Scanner (System.in);
		
		//Ucitavanje stepena Farenhajta od korisnika
		System.out.println ("Koliko stepeni Farenhajta? ");
		f = tastatura.nextInt();
		
		//Izracunavanje stepena Celzijusa po formuli
		c = 5 * (f - 32) / 9;
		
		//Prikazivanje rezultata na ekranu
		System.out.print (f + " stepeni Farenhajta = ");
		System.out.println (c + " stepeni Celzijusa");
		
	}
	
}
