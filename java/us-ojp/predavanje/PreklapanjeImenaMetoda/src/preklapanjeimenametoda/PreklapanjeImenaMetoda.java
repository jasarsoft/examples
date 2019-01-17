/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package preklapanjeimenametoda;

/**
 *
 * @author profesor
 */
public class PreklapanjeImenaMetoda {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int x = 5;
        int y = 10;
        
        System.out.println (odrediManji(uvecajZaJedan(x), y-1));
        
        System.out.println (odrediManji("Prvi string", "Ovo je duzi string"));
               
    }
    
    public static int uvecajZaJedan (int a){
        return a+1;
    }
    
    public static int odrediManji (int a, int b){
        if (a > b) {
            return b;
        } else 
            return a;
    }
    
    public static int odrediManji (int a, int b, int c){
        return a;
    }
    
    public static String odrediManji (String a, String b){
        if (a.length() > b.length()){
            return b;
        } else 
            return a;
    }
    
}
