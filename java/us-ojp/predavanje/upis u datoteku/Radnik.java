package datoteka;

public class Radnik {
	
	//privatna polja
	private String ime;
	private long jmbg;
	private int staz;
	private double plata;
	
	//javni konstruktor
	public Radnik (String i, long id, int s, double p) {
		ime = i;
		jmbg = id;
		staz = s;
		plata = p;
	}
	
	public String getIme () {
		return ime;
	}
	
	public long getJmbg () {
		return jmbg;
	}
	
	public int getStaz () {
		return staz;
	}
	
	public double getPlata () {
		return plata;
	}
	
	public void setStaz (int s) {
		staz = s;
	}
	
	public void povecajPlatu (double procenat) {
		plata += plata * procenat / 100;
	}

	public String toString (){
		return ime;
	}
}
