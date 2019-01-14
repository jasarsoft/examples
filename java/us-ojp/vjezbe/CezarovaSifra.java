
public class CezarovaSifra {
	
	public static void main (String[] args){
		
		String s = "cao narode";
		int d = 3;
		
		String sifra = sifra(s, d);
		System.out.println (sifra);
		
		String desifrovano = desifruj(sifra, d);
		System.out.println (desifrovano);
	}
	
	public static String sifra (String s, int d) {
		String resStr;
		char c;
		int ci;
		resStr = "";
		for (int i = 0; i < s.length(); i++) {
		c = s.charAt(i);
		ci = (int)c;
		ci += d;
		c = (char)ci;
		resStr = resStr + c;
		}
		return resStr;
	}
	
	public static String desifruj (String s, int d){
		String resStr;
		char c;
		int ci;
		resStr = "";
		for (int i = 0; i < s.length(); i++) {
		c = s.charAt(i);
		ci = (int)c;
		ci -= d;
		c = (char)ci;
		resStr = resStr + c;
		}
		return resStr;
	}

}
