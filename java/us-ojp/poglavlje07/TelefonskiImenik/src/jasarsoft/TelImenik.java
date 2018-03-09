/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.util.*;
/**
 *
 * @author jasarsoft
 */
public class TelImenik {
    private ArrayList<TelStavka> imenik; //niz stavki
    
    //kontruktor klase konstruise prazan imenik
    public TelImenik(){
        imenik = new ArrayList<TelStavka>();
    }
    
    private int nadjiStavku(String imeOsobe){
        for(int i = 0; i < imenik.size(); i++){
            TelStavka s = imenik.get(i);
            //da li i-ta osoba ima dato ime
            if(s.ime.equals(imeOsobe))
                return i; //i-ta osoba ima dato ime
        }
        
        return -1; //nema osobe sa datim imenom
    }
    
    public String nadjiBroj(String imeOsobe){
        int i = nadjiStavku(imeOsobe);
        if(i > 0) //osoba se nalazi u imeniku
            return imenik.get(i).telBroj; //ako da vrati njego tel broj
        else
            return null; //ako ne, vrati null referencu
    }
    
    public void dodajStavku(String imeOsobe, String brojOsobe){
        if(imeOsobe == null || brojOsobe == null){
            System.out.println("Greska: prazno ime ili broj!");
            return;
        }
        
        int i = nadjiStavku(imeOsobe);
        if(i >= 0) //osoba se nalazi u imenku
            imenik.get(i).telBroj = brojOsobe; //ako da, zamjeni stari broj novim
        else{
            //ako ne, dodaj novi stavku ime/broj u imenik
            TelStavka s = new TelStavka();
            s.ime = imeOsobe;
            s.telBroj = brojOsobe;
            imenik.add(s);
        }
    }
    
    public void ukloniStavku(String imeOsobe){
        int i = nadjiStavku(imeOsobe);
        if(i >= 0) //osoba se nalazi u imeniku
            imenik.remove(i); //ako da ukloni ga
    }
}
