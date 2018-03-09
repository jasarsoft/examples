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
public class KockaZaIgru {
    public int broj;    //broj koji je pao
    
    public KockaZaIgru(){       //konstruktor bez parametara
        baci();                 //poziv metoda baci()
    }
    
    public KockaZaIgru(int n){  //konstruktor sa parametrom
        broj = n;
    }
    
    public void baci(){         //bacanje kocke
        broj = (int)(Math.random() * 6) + 1;
    }
}
