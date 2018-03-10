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
public class Dijete {
    private String ime;
    private int uzrast;
    
    //konstruktor
    public Dijete(String ime, int uzrast){
        this.ime = ime;
        this.uzrast = uzrast;
    }
    
    //metod prikazi
    public void prikazi(){
        System.out.println();
        System.out.println("Ime: " + ime);
        System.out.println("Uzrast: " + uzrast);
    }
    
    public boolean equals(Object obj){
        if(obj == null || !(obj instanceof Dijete))
            return false;
        
        Dijete drugoDijete = (Dijete)obj; //konverzija tipa obj u Dijete
        if(this.ime == drugoDijete.ime && this.uzrast == drugoDijete.uzrast){
            //drugo dijete ima isto ime i uzrazt kao ovo dijete
            //pa se podrazumjeva da su jednaki objekti
            return true;
        }
        
        return false;    
    }
    
    public String toString(){
        return ime + " (" + uzrast + ")";
    }
}
