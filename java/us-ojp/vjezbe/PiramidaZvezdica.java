
public class PiramidaZvezdica {
	
	public static void main (String[] args){
		
		int visina = 10;
		
		for (int red = 1; red <= visina; red++) {
		// 1 iteracija za svaki red piramide
			for (int i = 1; i <= visina - red; i++)
				System.out.print(" "); // stampa pocetne praznine
			for (int i = 1; i <= red * 2 - 1; i++)
				System.out.print("*"); // stampa sekvencu zvezdica
			System.out.println(); // stampa novi red, red je zavrsen
		}
		
	}

}
