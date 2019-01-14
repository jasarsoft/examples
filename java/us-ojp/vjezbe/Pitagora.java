import java.util.Scanner;

public class Pitagora {
	
	public static void main (String[] args){
		int a;
		int b;
		
		Scanner tastatura = new Scanner(System.in);
		System.out.println ("Unesite stranice trougla a i b: ");
		a = tastatura.nextInt();
		b = tastatura.nextInt();
		
		double c;
		//c = sqrt (a^2 + n^2)
		c = Math.sqrt(Math.pow(a, 2) + Math.pow(b,2)); 
		System.out.println ("Stranica c = " + c);
		
	}

}
