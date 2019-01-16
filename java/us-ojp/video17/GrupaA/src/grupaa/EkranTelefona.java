/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package grupaa;

/**
 *
 * @author jasarsoft
 */
public class EkranTelefona {
    private double sirina, visina;

    public double getSirina() {
        return sirina;
    }

    public double getVisina() {
        return visina;
    }

    public EkranTelefona(double sirina, double visina) {
        this.sirina = sirina;
        this.visina = visina;
    }
    
    public double getDiagonala() {
        return Math.sqrt(Math.pow(sirina, 2.0) + Math.pow(visina, 2.0));
    }
    
    public static void zamjeniMjesta(EkranTelefona a, EkranTelefona b) {
        double tmp = a.sirina;
        a.sirina = b.sirina;
        b.sirina = tmp;
        
        tmp = a.visina;
        a.visina = b.visina;
        b.visina = tmp;
    }
}
