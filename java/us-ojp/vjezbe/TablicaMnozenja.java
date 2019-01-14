
public class TablicaMnozenja {
	
	static final int NMAX = 10;
	
	public static void main (String[] args) {
		int red, kolona;
		for (red = 1; red <= NMAX; red++) {
			for (kolona = 1; kolona <= NMAX; kolona++)
				System.out.print(red * kolona + " ");
			System.out.println();
		}
	}

}
