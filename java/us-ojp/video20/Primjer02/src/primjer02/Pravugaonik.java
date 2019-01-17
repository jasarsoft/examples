/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primjer02;

/**
 *
 * @author jasarsoft
 */
public class Pravugaonik {
    private double a, b;

    public double getA() {
        return a;
    }

    public double getB() {
        return b;
    }

    public Pravugaonik(double a, double b) {
        this.a = a;
        this.b = b;
    }

    @Override
    public String toString() {
        return String.format("(a,b) = (%12.4f, %12.4f); (P,O) = (%12.4f, %12.4f)", a, b, getPovrsina(), getObim());
    }
    
    public double getPovrsina() {
        return a * b;
    }
    
    public double getObim() {
        return 2 * (a+b);
    }
}
