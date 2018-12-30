
package primjer01;

public class Stavka {
    private String naziv;
    private double cijena;

    public String getNaziv() {
        return naziv;
    }

    public double getCijena() {
        return cijena;
    }

    public Stavka(String naziv, double cijena) {
        this.naziv = naziv;
        this.cijena = cijena;
    }
}
