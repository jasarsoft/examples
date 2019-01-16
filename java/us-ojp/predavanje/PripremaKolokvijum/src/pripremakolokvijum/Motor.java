/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pripremakolokvijum;

/**
 *
 * @author profesor
 */
public class Motor {
    
    private double kubikaza;
    private double hp;
    private String brojMotora;
    
    public Motor (double kubikaza, double hp, String brojMotora){
        this.kubikaza = kubikaza;
        this.hp = hp;
        this.brojMotora = brojMotora;
    }

    public double getKubikaza() {
        return kubikaza;
    }

    public void setKubikaza(double kubikaza) {
        this.kubikaza = kubikaza;
    }

    public double getHp() {
        return hp;
    }

    public void setHp(double hp) {
        this.hp = hp;
    }

    public String getBrojMotora() {
        return brojMotora;
    }

    public void setBrojMotora(String brojMotora) {
        this.brojMotora = brojMotora;
    }
    
    @Override
    public String toString () {
        return "Motor [ kubikaza = " + this.kubikaza + ", hp = " + this.hp + ", broj motora = " + brojMotora + " ]";
    }
    
    public static void zameniMesta (Motor m1, Motor m2) {
        double temp = m1.kubikaza;
        m1.kubikaza = m2.kubikaza;
        m2.kubikaza = temp;
        
        temp = m1.hp;
        m1.hp = m2.hp;
        m2.hp = temp;
        
        String temp2 = m1.brojMotora;
        m1.brojMotora = m2.brojMotora;
        m2.brojMotora = temp2;
    }
    
}
