
package primjer01;

public class Primjer01 {

    public static void main(String[] args) {
        
        Vektor v1 = new Vektor(4.5, 11.2);
        Vektor v2 = new Vektor(1.2, 10.4);
        
        Vektor v3 = new Vektor(v1);
        
        v3.saberi(v2);
        v3.skaliraj(3.0);
        v3.oduzmi(v1);
        
        System.out.println("V1 = " + v1);
        System.out.println("V2 = " + v2);
        System.out.println("V3 = " + v3);
    }
    
}
