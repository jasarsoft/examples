
package domacizadatak;

import java.util.Scanner;

public class DomaciZadatak {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        System.out.println("Tacke A, B i C obrazuju trouga.");
        double aX = unosDouble(s, "Unesite X koordinate tacke A: ");
        double aY = unosDouble(s, "Unesite Y koordinate tacke A: ");
        double bX = unosDouble(s, "Unesite X koordinate tacke B: ");
        double bY = unosDouble(s, "Unesite Y koordinate tacke B: ");
        double cX = unosDouble(s, "Unesite X koordinate tacke C: ");
        double cY = unosDouble(s, "Unesite Y koordinate tacke C: ");
        
        System.out.println("Tacka O je tacka u odnosu na koju ce biti vrsena rotacija u prostoru.");
        double oX = unosDouble(s, "Unesite X kooridnatu tacke O: ");
        double oY = unosDouble(s, "Unesite Y kooridnatu tacke O: ");
        
        double ugaoRotacije = -unosDouble(s, "Unesite ugao za koji se rotira: ");
        ugaoRotacije = Math.toRadians(ugaoRotacije);
        
        if ( (aX == bX && aY == bY) || (bX == cX && bY == cY) || (cX == aX && cY == aY)) {
            System.out.println("Nije moguce da se tacke nalaze na istim koordinatama.");
            return;
        }
        
        double newAX = rotiranoX(oX, oY, aX, aY, ugaoRotacije);
        double newAY = rotiranoY(oX, oY, aX, aY, ugaoRotacije);
        double newBX = rotiranoX(oX, oY, aX, aY, ugaoRotacije);
        double newBY = rotiranoY(oX, oY, aX, aY, ugaoRotacije);
        double newCX = rotiranoX(oX, oY, aX, aY, ugaoRotacije);
        double newCY = rotiranoY(oX, oY, aX, aY, ugaoRotacije);
        
        System.out.println("Nakon rotacije tacka A, B i C i njihove nove koordinate:");
        
        System.out.println("Tacka A (X=" + newAX + ", Y=" + newAY + ")");
        System.out.println("Tacka B (B=" + newBX + ", Y=" + newBY + ")");
        System.out.println("Tacka C (C=" + newCX + ", Y=" + newCY + ")");
    }
    
    public static double unosDouble(Scanner s, String poruka) {
        System.out.print(poruka);
        return s.nextDouble();
    }
    
    public static double rotiranoX(double oX, double oY, double x, double y, double ugao) {
        return (x-oX)*Math.cos(ugao) - (y-oY)*Math.sin(ugao) + oX;
    }
    
    public static double rotiranoY(double oX, double oY, double x, double y, double ugao) {
        return (x-oX)*Math.sin(ugao) + (y-oY)*Math.cos(ugao) + oY;
    }
}
