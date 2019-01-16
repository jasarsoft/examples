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
public class MobilniTelefoni {
    private String proizvodjac, model;
    private int godinaProizvodnje, kolicinaRAM, kolicinaDisk;
    private EkranTelefona ekran;

    public String getProizvodjac() {
        return proizvodjac;
    }

    public String getModel() {
        return model;
    }

    public int getGodinaProizvodnje() {
        return godinaProizvodnje;
    }

    public int getKolicinaRAM() {
        return kolicinaRAM;
    }

    public int getKolicinaDisk() {
        return kolicinaDisk;
    }

    public EkranTelefona getEkran() {
        return ekran;
    }

    public MobilniTelefoni(String proizvodjac, String model, int godinaProizvodnje, int kolicinaRAM, int kolicinaDisk, EkranTelefona ekran) {
        this.proizvodjac = proizvodjac;
        this.model = model;
        this.godinaProizvodnje = godinaProizvodnje;
        this.kolicinaRAM = kolicinaRAM;
        this.kolicinaDisk = kolicinaDisk;
        this.ekran = ekran;
    }
    
    public double ocjenaPodobnosti() {
        if (ekran.getDiagonala() < 5.0) {
            return ekran.getDiagonala() * kolicinaRAM / (2020 - godinaProizvodnje);
        } else {
            return ekran.getDiagonala() * kolicinaDisk / (2020 - godinaProizvodnje);
        }
    }
    
    public static void zamjeniMjesto(MobilniTelefoni a, MobilniTelefoni b) {
        EkranTelefona.zamjeniMjesta(a.ekran, b.ekran);
        
        String tmpS = a.proizvodjac;
        a.proizvodjac = b.proizvodjac;
        b.proizvodjac = tmpS;
        
        tmpS = a.model;
        a.model = b.model;
        b.model = tmpS;
        
        int tmpI = a.godinaProizvodnje;
        a.godinaProizvodnje = b.godinaProizvodnje;
        b.godinaProizvodnje = tmpI;
        
        tmpI = a.kolicinaRAM;
        a.kolicinaRAM = b.kolicinaRAM;
        b.kolicinaRAM = tmpI;
        
        tmpI = a.kolicinaDisk;
        a.kolicinaDisk = b.kolicinaDisk;
        b.kolicinaDisk = tmpI;
    }

    @Override
    public String toString() {
        String prikaz = "";
        
        prikaz += String.format("%-24s%-17s%-20s%-19s\n", 
                "Proizvodjac:",
                proizvodjac,
                "Model",
                model);
        
        prikaz += String.format("%-24s%13d    %-20s%16.2f PP\n",
                "Godina proizvodnje",
                godinaProizvodnje,
                "Ocjena podobnosit",
                ocjenaPodobnosti());
        
        prikaz += String.format("%-24s%5.2f x %5.2f in %-20s%16.2f in\n", 
                "Sirina i visina ekrana",
                ekran.getSirina(),
                ekran.getVisina(),
                "Dijagonala ekrana:",
                ekran.getDiagonala());
        
        prikaz += String.format("%-24s%13.2f MB %-20s%16.2f MB\n", 
                "Kolicina RAM memorije",
                kolicinaRAM / (1024.0 * 1024.0),
                "Kolicina skladista",
                kolicinaDisk / (1024. * 1024.));
        
        return prikaz;
    }
    
    
}
