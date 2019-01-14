import java.util.Scanner;


public class SlozenaIfElse {
	
	public static void main (String[] args){
		System.out.println ("Unesite broj poena: ");
		Scanner tastatura = new Scanner (System.in);
		int ocena;
		int brojPoena = tastatura.nextInt();
		
		// Podrazumeva se 0 <= brojPoena <= 100
		if (brojPoena >= 91)
			ocena = 10;
		else if (brojPoena >= 81)
			ocena = 9;
		else if (brojPoena >= 71)
			ocena = 8;
		else if (brojPoena >= 61)
			ocena = 7;
		else if (brojPoena >= 51)
			ocena = 6;
		else
			ocena = 5;

		System.out.println ("Dobili ste ocenu: " + ocena);
	}

}
