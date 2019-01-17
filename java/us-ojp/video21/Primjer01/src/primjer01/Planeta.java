package primjer01;

/**
 *
 * @author jasarsoft
 */
public class Planeta {
    private String ime;
    private double masa, x, y;

    public Planeta(String ime, double masa, double x, double y) {
        this.ime = ime;
        this.masa = masa;
        this.x = x;
        this.y = y;
    }

    public String getIme() {
        return ime;
    }

    public double getMasa() {
        return masa;
    }

    public double getX() {
        return x;
    }

    public double getY() {
        return y;
    }
    
    public double getUdaljenost(Planeta p) {
        return Math.sqrt(Math.pow(p.getX() - this.x, 2) + Math.pow(p.getY() - this.y, 2));
    }
    
    public double getSilaPrivlacenja(Planeta p) {
        return 6.67408e-11 * this.getMasa() * p.getMasa() / Math.pow(this.getUdaljenost(p), 2);
    }
}
