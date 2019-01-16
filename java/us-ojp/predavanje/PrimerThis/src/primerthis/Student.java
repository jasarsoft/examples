/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerthis;

/**
 *
 * @author profesor
 */
public class Student {
    
    private String ime;
    private long jmbg;
    private String indeks;
    private int godinaStudija;
    private double prosek;
    
    public Student (String ime, long jmbg, String indeks, int godinaStudija, double prosek){
        this.ime = ime;
        this.jmbg = jmbg;
        this.indeks = indeks;
        this.godinaStudija = godinaStudija;
        this.prosek = prosek;
    }
    
    //napravi brucosa, godina = 1
    /*
    public Student (String ime, long jmbg, String indeks){
        this.ime = ime;
        this.jmbg = jmbg;
        this.indeks = indeks;
        this.godinaStudija = 1;
    }*/
    
    public Student (String ime, long jmbg, String indeks){
        this(ime, jmbg, indeks, 1, 0);
        System.out.println ("napravljen brucos");
    }
    
    public String getIme (){
        return this.ime;
    }
    
    public long getJmbg () {
        return this.jmbg;
    }
    
    public String getIndeks (){
        return this.indeks;
    }
    
    public int getGodinaStudija (){
        return this.godinaStudija;
    }
    
    public double getProsek (){
        return this.prosek;
    }
    
    public void setIndeks (String indeks){
        this.indeks = indeks;
    }
    
    public void setGodinaStudija (int godinaStudija){
        this.godinaStudija = godinaStudija;
    }
    
    public void setProsek (double prosek){
        this.prosek = prosek;
    }
    
    //uporedi dva studenta preko proseka, vrati studenta sa vecim prosekom
    public Student uporediProsek (Student drugi){
        if (this.getProsek() > drugi.getProsek()){
            return this;
        }
        return drugi;
    }
    
    public String toString () {
        return this.ime + " " + this.indeks + " prosek: " + this.prosek;
    }
    
}
