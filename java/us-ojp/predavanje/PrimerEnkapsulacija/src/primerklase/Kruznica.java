/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerklase;

/**
 *
 * @author profesor
 */
public class Kruznica {
    //treba nam poluprecnik, i treba nam Tacka u kojoj je centar
    private Tacka centar;
    private double poluprecnik;
    
    //konstruktori
    public Kruznica (Tacka t, double r){
        centar = t;
        poluprecnik = r;
    }
    
    public Kruznica (double x, double y, double r){
        centar = new Tacka(x, y); //pravimo novu tacku sa zadatim koord
        poluprecnik = r;
    }
    
    //get i set metode
    public double getPoluprecnik () {
        return poluprecnik;
    }
    
    public Tacka getCentar () {
        return centar;
    }
    
    public void setPoluprecnik (double r){
        poluprecnik = r;
    }
    
    public void setCentar (Tacka t){
        centar = t;
    }
    
    public String toString (){
        return "Kruznica sa centrom u " + centar.toString() + " i poluprecnikom = " + poluprecnik;
    }
    
    //povrsina i obim kruga
    public double izracunajObim () {
        return 2 * poluprecnik * Math.PI;
    }
    
    public double izracunajPovrsinu () {
        return Math.pow(poluprecnik, 2) * Math.PI;
    }
    
    //staticka metoda koja poredi dve kruznice po povrsini i vraca vecu od njih
    public static Kruznica uporediDveKruznice (Kruznica k1, Kruznica k2){
        if (k1.izracunajPovrsinu() > k2.izracunajPovrsinu()) 
            return k1;
        else return k2;
    }
    
}
