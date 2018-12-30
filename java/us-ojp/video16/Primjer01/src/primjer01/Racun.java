
package primjer01;

public class Racun {
    private String imeRadnje, ulicaIBroj, grad;
    private String datum, vrijeme;
    private String kasir;
    
    private int transakcija;
    
    private Stavka[] stavke = new Stavke[50];
    private int sljedecaStavka = 0;

    public Racun(String imeRadnje, String ulicaIBroj, String grad, String datum, String vrijeme, String kasir) {
        this.imeRadnje = imeRadnje;
        this.ulicaIBroj = ulicaIBroj;
        this.grad = grad;
        this.datum = datum;
        this.vrijeme = vrijeme;
        this.kasir = kasir;
    }
    
    public void dodajStavku(Stavka s) {
        stavke[sljedecaStavka] = s;
        sljedecaStavka++;
    }
}
