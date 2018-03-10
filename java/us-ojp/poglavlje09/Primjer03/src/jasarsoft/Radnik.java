/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;

/**
 *
 * @author jasarsoft
 */
public class Radnik implements Comparable {
    String ime;     //ime i prezime radnika
    double plata;   //plata radnika
    
    //ostala polja i metodi
    
    public int compareTo(Object o){
        Radnik drugiRadnik = (Radnik)o;
        
        if(this.plata < drugiRadnik.plata) return -1;
        if(this.plata > drugiRadnik.plata) return +1;
        
        return 0;
    }
}
