
package primjer01;

public class Veverica {
    private String ime;
    private String boja;
    private Ruka levaRuka;
    private Ruka desnaRuka;
    private String staDrzi;

    public void setIme(String ime) {
        this.ime = ime;
    }

    public void setBoja(String boja) {
        this.boja = boja;
    }

    public Veverica(String ime, String boja) {
        this.setIme(ime);
        this.setBoja(boja);
        this.levaRuka = new Ruka();
        this.desnaRuka = new Ruka();
        this.staDrzi = "NISTA";
    }

    public String getIme() {
        return ime;
    }

    public String getBoja() {
        return boja;
    }

    public String getStaDrzi() {
        return staDrzi;
    }
    
    public void proveriDaLiMozeDaDrziNesto (Ruka ruka) {        
        if (ruka.jeIspruzena()) {
            System.out.println(ime + ": je ispustila " + staDrzi);
            staDrzi = "NISTA";
        }
    }
    
    public void savijLevuRuku() {
        levaRuka.savij();
        System.out.println(ime + ": je savila levu ruku.");
    }
    
    public void savijDesnuRuku() {
        desnaRuka.savij();
        System.out.println(ime + ": je savila desnu ruku.");
    }
    
    public void ispruziLevuRuku() {
        levaRuka.ispruzi();
        System.out.println(ime + ": je ispruzila levu ruku.");
        
        proveriDaLiMozeDaDrziNesto(desnaRuka);
    }
    
    public void ispruziDesnuRuku() {
        desnaRuka.ispruzi();
        System.out.println(ime + ": je ispruzila desnu ruku.");
        
        proveriDaLiMozeDaDrziNesto(levaRuka);
    }
    
    public void pridrzi(String sta) {
        if (levaRuka.jeSavijana() || desnaRuka.jeSavijana()) {
            staDrzi = sta;
            System.out.println(ime + ": pridrzava " + sta);
        } else {
            System.out.println(ime + ": ne moze da pridrzi " + sta);
        }
    }
}
