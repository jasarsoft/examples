import java.util.Scanner;

public class IfElse {
	
	public static void main (String[] args){
		//provera da li je korisnik punoletan
		System.out.println ("Unesite vase godine: ");
		Scanner tastatura = new Scanner (System.in);
		int godine = tastatura.nextInt();
		
		if (godine >= 18){
			System.out.println ("Korisnik je punoletan. ");
		} else {
			System.out.println ("Korisnik je maloletan. ");
		}
	}

}
