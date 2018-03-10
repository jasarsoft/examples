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
public class Radnik {
    String ime;         //ime i prezime radnika
    long jmbg;          //jedinstven broj radnika
    long racun;         //bankovni racun radnika
    
    public void ulatiPlatu(){
        System.out.print("Plata za " + ime + " ,broj " + jmbg);
        System.out.println(" uplacena na racun " + racun);
    }
}
