/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primjer01;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author jasarsoft
 */
public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        List<Student> lista = new ArrayList();
        
        lista.add(new Student("Pera", "Peric", "45324234", "2007300400"));
        lista.add(new Student("Ivana", "Ivanovic", "23432432", "2007340400"));
        lista.add(new Student("Zoran", "Zoric", "54432424", "2007400600"));
        
        System.out.println("Pre brisanja:");
        for (Student s: lista) {
            System.out.println(s.getJmbg());
        }
        
        lista.remove(1);
        
        System.out.println("Poslije brisanja");
        for (Student s: lista) {
            System.out.println(s.getJmbg());
        }
        
        lista.add(1, new Student("Milica", "Milic", "054343242", "24214354352"));
        
        System.out.println("Poslije dodavanja indeksa");
        for (Student s: lista) {
            System.out.println(s.getJmbg());
        }
    }
    
}
