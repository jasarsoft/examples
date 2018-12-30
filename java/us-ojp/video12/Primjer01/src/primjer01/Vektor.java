
package primjer01;

import java.util.Scanner;

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
    
    public static Vektor unosSaTastature(){
        Scanner s = new Scanner(System.in);
        System.out.print("Unesite velicine komonenti vektora x i y: ");
        
        Vektor v = new Vektor();
        v.setX(s.nextDouble());
        v.setY(s.nextDouble());
        
        return v;
    }
    
    public static void zamjeni(Vektor a, Vektor b) {
        double tmpX = a.getX();
        a.setX(b.getX());
        b.setX(tmpX);
        
        double tmpY = a.getY();
        a.setY(b.getY());
        b.setY(tmpY);
    }
    
    public enum POREDAK {OPADAJUCI, RASTUCI };
    
    public static void sort(Vektor[] niz, POREDAK poredak) {
        for (int j = 0; j < niz.length - 1; j++) {
            for (int i = 0; i < niz.length - 1; i++) {
                if (poredak == POREDAK.RASTUCI) {
                    if (niz[i].intezitet() > niz[i+1].intezitet()) {
                        Vektor.zamjeni(niz[i], niz[i+1]);
                    }
                } else if (poredak == POREDAK.OPADAJUCI) {
                    if (niz[i].intezitet() > niz[i+1].intezitet() ) {
                        Vektor.zamjeni(niz[i], niz[i+1]);
                    }
                }
            }
        }
    }
}
