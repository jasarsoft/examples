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
public class RadnikPlacenPoSatu extends Radnik {
    double brojSati;    //broj radnih sati radnika
    double cijenaSata;    //iznos za jedan radni sat
    
    public double izracunajPlatu(){
        return brojSati * cijenaSata;
    }
}
