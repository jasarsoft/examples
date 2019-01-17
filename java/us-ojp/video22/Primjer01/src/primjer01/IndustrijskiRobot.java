/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primjer01;

import java.io.FileInputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author jasarsoft
 */
public class IndustrijskiRobot {
    public enum VrstaProgona {
        MAGNETNI_LINEARNI_AKTUATOR,
        ELEKTROMOTORNI_PROGON,
        HIDRAULICNI_POGON
    };
    
    private String proizvodjac, model;
    private long godinaProizvodnje, stepeniSlobodeKretanja, maxBrojSati;
    private double potrosnja;
    private VrstaProgona vrstaPogona;

    public long getGodinaProizvodnje() {
        return godinaProizvodnje;
    }

    public long getStepeniSlobodeKretanja() {
        return stepeniSlobodeKretanja;
    }

    public long getMaxBrojSati() {
        return maxBrojSati;
    }

    public double getPotrosnja() {
        return potrosnja;
    }

    public VrstaProgona getVrstaPogona() {
        return vrstaPogona;
    }

    public IndustrijskiRobot(String proizvodjac, String model, long godinaProizvodnje, long stepeniSlobodeKretanja, long maxBrojSati, double potrosnja, VrstaProgona vrstaPogona) {
        this.proizvodjac = proizvodjac;
        this.model = model;
        this.godinaProizvodnje = godinaProizvodnje;
        this.stepeniSlobodeKretanja = stepeniSlobodeKretanja;
        this.maxBrojSati = maxBrojSati;
        this.potrosnja = potrosnja;
        this.vrstaPogona = vrstaPogona;
    }
    
    public double getEfikasnost() {
        double L;
        if (vrstaPogona == VrstaProgona.MAGNETNI_LINEARNI_AKTUATOR) {
            L = 2.0;
        } else if (vrstaPogona == VrstaProgona.ELEKTROMOTORNI_PROGON) {
            L = 1.0;
        } else {
            L = 0.33;
        }
        
        return (potrosnja * Math.sqrt(maxBrojSati)) / ((stepeniSlobodeKretanja * 2) * L);
    }

    @Override
    public String toString() {
        String rez = "";
        
        rez += String.format("%-20s%-20s%-30s%9.2f w\n",
                "Naziv proizvodjaca", 
                proizvodjac,
                "Potrosnja energije",
                potrosnja);
        
        rez += String.format("%-20s%-20s%-30s%6d sati\n", 
                "Naziv modela",
                model,
                "Max broj sati rada",
                maxBrojSati);
        
        rez += String.format("%-20s%19d %-30s%6d sslk\n",
                "Godina proizvodnje",
                godinaProizvodnje,
                "Broj stepeni slobode kretanja",
                stepeniSlobodeKretanja);
        
        String pogon = "";
        
        if (vrstaPogona == VrstaProgona.MAGNETNI_LINEARNI_AKTUATOR) {
            pogon = "Magnetni linearni pogon";
        } else if (vrstaPogona == VrstaProgona.ELEKTROMOTORNI_PROGON) {
            pogon = "Elektromotorni pogon";
        } else {
            pogon = "Hidraulicni pogon";
        }
        
        rez += String.format("%-7s%-33s%-30s%9.2f #", 
                "Pogon:",
                pogon,
                "Efikasnost:",
                getEfikasnost());
        
        return rez;
    }
    
    public static List<IndustrijskiRobot> load(String imeDatoteke) {
        List<IndustrijskiRobot> lista = new ArrayList<>();
        
        try {
            FileInputStream fis = new FileInputStream(imeDatoteke);
            Scanner s = new Scanner(fis);
            
            while (s.hasNext()) {
                double potrosnja = s.nextDouble();
                long sati = s.nextLong();
                long godina = s.nextLong();
                String proizvodjac = s.nextLine().trim();
                long sslk = s.nextLong();
                String pogonAkrom = s.next().trim();
                String model = s.nextLine().trim();
                
                VrstaProgona vp = null;
                
                if (pogonAkrom.equals("MLA")) {
                    vp = VrstaProgona.MAGNETNI_LINEARNI_AKTUATOR;
                } else if (pogonAkrom.equals("EMP")) {
                    vp = VrstaProgona.ELEKTROMOTORNI_PROGON;
                } else {
                    vp = VrstaProgona.HIDRAULICNI_POGON;
                }
                
                IndustrijskiRobot ir;
                ir = new IndustrijskiRobot(proizvodjac, model, godina, sslk, sati, potrosnja, VrstaProgona.HIDRAULICNI_POGON);
                lista.add(ir);
            }
            
            s.close();
            fis.close();
                    
        } catch (Exception e) {
            System.out.println("Greska prilikom loadirnaja datoteke.");
        }
        
        
        
        return lista;
    }
}
