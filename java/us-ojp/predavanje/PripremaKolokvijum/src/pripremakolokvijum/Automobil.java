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
public class Automobil {
    
    private String marka;
    private String model;
    private String registracija;
    private int brojVrata;
    private Motor motor;
    private VrstaGoriva gorivo;
    
    public enum VrstaGoriva {BENZIN, DIZEL, GAS, HIBRID }

    public Automobil(String marka, String model, String registracija, int brojVrata, VrstaGoriva gorivo, Motor motor) {
        this.marka = marka;
        this.model = model;
        this.registracija = registracija;
        this.brojVrata = brojVrata;
        this.gorivo = gorivo;
        this.motor = motor;
    }
    
    public Automobil(String marka, String model, String registracija, int brojVrata, VrstaGoriva gorivo, double kubikaza, double hp, String brMotora) {
        this.marka = marka;
        this.model = model;
        this.registracija = registracija;
        this.brojVrata = brojVrata;
        this.gorivo = gorivo;
        this.motor = new Motor (kubikaza, hp, brMotora);
    }

    public String getMarka() {
        return marka;
    }

    public void setMarka(String marka) {
        this.marka = marka;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public String getRegistracija() {
        return registracija;
    }

    public void setRegistracija(String registracija) {
        this.registracija = registracija;
    }

    public int getBrojVrata() {
        return brojVrata;
    }

    public void setBrojVrata(int brojVrata) {
        this.brojVrata = brojVrata;
    }

    public Motor getMotor() {
        return motor;
    }

    public void setMotor(Motor motor) {
        this.motor = motor;
    }

    public VrstaGoriva getGorivo() {
        return gorivo;
    }

    public void setGorivo(VrstaGoriva gorivo) {
        this.gorivo = gorivo;
    }
    
    
    public String toString () {
        return "Automobil " + marka + " " + model + " " + gorivo + " " + motor.toString();
    }
    
    public static void zameniMesta (Automobil a1, Automobil a2){
        Motor.zameniMesta(a1.motor, a2.motor);
        
        String temp = a1.marka;
        a1.marka = a2.marka;
        a2.marka = temp;
        
        temp = a1.model;
        a1.model = a2.model;
        a2.model = temp;
        
        temp = a1.registracija;
        a1.registracija = a2.registracija;
        a2.registracija = temp;
        
        int temp2 = a1.brojVrata;
        a1.brojVrata = a2.brojVrata;
        a2.brojVrata = temp2;
        
        VrstaGoriva temp3 = a1.gorivo;
        a1.gorivo = a2.gorivo;
        a2.gorivo = temp3;
        
        
    }
    
}
