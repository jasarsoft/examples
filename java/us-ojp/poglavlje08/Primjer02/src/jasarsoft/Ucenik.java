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
public class Ucenik extends Dijete {
    private String skola;
    private int razred;
    
    //konstruktor
    public Ucenik(String ime, int uzrast, String skola, int razred){
        super(ime, uzrast);
        this.skola = skola;
        this.razred = razred;
        System.out.println("Konstruisan ucenik....");
        prikazi();
    }
    
    //metod prikazi
    public void prikazi(){
        super.prikazi();
        System.out.println("Skola: " + skola);
        System.out.println("Razred: " + razred);
    }
}
