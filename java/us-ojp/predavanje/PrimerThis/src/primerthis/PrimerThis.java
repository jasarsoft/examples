/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerthis;

/**
 *
 * @author profesor
 */
public class PrimerThis {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Student s1 = new Student ("Pera Peric", 111111, "2017/200500", 1, 9.0);
        Student s2 = new Student ("Laza Lazic", 22222, "2017/300400", 3, 8.5);
        
        Student veci = s1.uporediProsek(s2);
        System.out.println ("Student sa vecim prosekom: ");
        System.out.println (veci);
        
        //pravljenje brucosa
        Student b1 = new Student ("Mika Mikic", 222333, "2017/535255");
        System.out.println (b1.toString());
        
        //promena godine studenta i proseka
        b1.setGodinaStudija(2);
        b1.setProsek(8.3);
                
        Student[] nizStudenata = new Student[3];
        nizStudenata[0] = s1;
        nizStudenata[1] = s2;
        nizStudenata[2] = b1;
        
        System.out.println ("Stampanje niza studenata pomocu for each");
        
        for (Student s : nizStudenata){
            System.out.println (s.toString());
        }
    }
    
}
