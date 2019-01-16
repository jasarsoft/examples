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
public class Tacka {
    //dve koordinate, x i y
    //enkapsulacija, polja su private
    private double x;
    private double y;
    
    public static final Tacka ORG = new Tacka ();
    
    public Tacka () {}
    
    public Tacka (double xx, double yy){
        x = xx;
        y = yy;
    }
    
    public Tacka (double xx) {
        x = xx;
        y = xx;
    }
    
    //get i set metode
    public double getX () {
        return x;
    }
    
    public double getY () {
        return y;
    }
    
    public void setX (double xx){
        x = xx;
    }
    
    public void setY (double yy){
        y = yy;
    }
    
    public String toString () {
        // (x,y)
        return "(" + x + "," + y + ")";
    }
    
    public static void odstampajKoordPoc (){
        System.out.println ("Koord pocetak = " + ORG.toString());
    }
    
    public static double rastojanjeIzmedjuTacaka (Tacka t1, Tacka t2){
        return Math.sqrt (Math.pow (t2.x - t1.x, 2) + Math.pow (t2.y - t1.y, 2));
    }
   
}
