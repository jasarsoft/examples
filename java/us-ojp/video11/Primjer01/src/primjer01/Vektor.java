
package primjer01;

public class Vektor {
    private double x, y;

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }

    public Vektor() {
        this.x = 0.0;
        this.y = 0.0;
    }

    public Vektor(double x, double y) {
        this.x = x;
        this.y = y;
    }
    
    public Vektor(Vektor v) {
        this.x = v.getX();
        this.y = v.getY();
    }
    
    public void saberi(Vektor v) {
        this.x += v.getX();
        this.y += v.getY();
    }
    
    public void oduzmi(Vektor v) {
        this.x -= v.getX();
        this.y -= v.getY();
    }
    
    public void skaliraj(double skalar) {
        this.x *= skalar;
        this.y *= skalar;
    }
    
    public double intezitet() {
        return Math.sqrt(Math.pow(this.x, 2.0) + Math.pow(this.y, 2.0));
    }

    @Override
    public String toString() {
        return "Vektor{" + "x=" + x + ", y=" + y + '}';
    }
}
