/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primjer01;

/**
 *
 * @author jasarsoft
 */
public class Test {
    private String predmet;
    private String nazivTesta;
    private int brojPitanja;
    private double brojTacnihOdgovora;

    public String getPredmet() {
        return predmet;
    }

    public String getNazivTesta() {
        return nazivTesta;
    }

    public int getBrojPitanja() {
        return brojPitanja;
    }

    public double getBrojTacnihOdgovora() {
        return brojTacnihOdgovora;
    }
    
    public double getBrojPoena() {
        return 30 * getBrojTacnihOdgovora() / getBrojPitanja();
    }

    public Test(String predmet, String nazivTesta, int brojPitanja, double brojTacnihOdgovora) {
        this.predmet = predmet;
        this.nazivTesta = nazivTesta;
        this.brojPitanja = brojPitanja;
        this.brojTacnihOdgovora = brojTacnihOdgovora;
    }
    
    public enum REZULTATI_TESTA {PAO, USLOVNO, POLOZIO};
    
    public REZULTATI_TESTA ocjeniTest() {
        double poeni = getBrojPoena();
        
        if (poeni < 11) {
            return REZULTATI_TESTA.PAO;
        } else if (poeni >= 11 && poeni < 17) {
            return REZULTATI_TESTA.USLOVNO;
        } else {
            return REZULTATI_TESTA.POLOZIO;
        }
    }

    @Override
    public String toString() {
        String opisnaOcjena = "";
        
        REZULTATI_TESTA rezultat = ocjeniTest();
        
        switch (rezultat) {
            case PAO:
                opisnaOcjena = "Pao";
                break;
            case USLOVNO:
                opisnaOcjena = "Uslovno polozio";
                break;
            case POLOZIO:
                opisnaOcjena = "Polozio";
                break;
        }
        
        return String.format("%-30s\t%-30s\t%.2f/%3d\t%.2f\t%s\n", 
                getPredmet(),
                getNazivTesta(),
                getBrojTacnihOdgovora(),
                getBrojPitanja(),
                getBrojPoena(),
                opisnaOcjena);
    }
    
    
}
