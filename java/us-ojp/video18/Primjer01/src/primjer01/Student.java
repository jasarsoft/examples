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
public class Student {
    private String ime, prezime, jmbg, indeks;

    public Student(String ime, String prezime, String jmbg, String indeks) {
        this.ime = ime;
        this.prezime = prezime;
        this.jmbg = jmbg;
        this.indeks = indeks;
    }

    public String getIme() {
        return ime;
    }

    public String getPrezime() {
        return prezime;
    }

    public String getJmbg() {
        return jmbg;
    }

    public String getIndeks() {
        return indeks;
    }

    @Override
    public String toString() {
        return "Student{" + "ime=" + ime + ", prezime=" + prezime + ", jmbg=" + jmbg + ", indeks=" + indeks + '}';
    }
    
    
}
