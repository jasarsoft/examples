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
public class PripremaKolokvijum {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
               
        
        Motor m1 = new Motor (1600, 110, "kash8325ajs62z782");
        System.out.println (m1.toString());
        
        //pravljenje automobila nacin1
        Automobil a1 = new Automobil ("Ford", "Fiesta", "BG123123", 5, Automobil.VrstaGoriva.DIZEL, m1);
        System.out.println (a1.toString());
        
        //drugi nacin pravljenja automobila
        Automobil a2 = new Automobil ("Opel", "Kadet", "BG-123-AB", 5, Automobil.VrstaGoriva.BENZIN, 1300, 65, "35bgds835bjsd");
        System.out.println (a2.toString());
    
        Automobil a3 = new Automobil ("Volkswagen", "Polo", "BG-222-CD", 3, Automobil.VrstaGoriva.BENZIN, new Motor (1200, 60, "asdg735j"));
        System.out.println (a3.toString());
    
        // primer kako radi bubblesort
        int[] niz = {1, 17, 4, 2, 55, 80, 33};
        System.out.println ("Niz pre sortiranja");
        for (int i = 0; i < niz.length; i++){
            System.out.print (niz[i] + " ");
        }
        
        System.out.println ();
        
        bubbleSort(niz);
        
        System.out.println ("Niz nakon sortiranja");
        for (int i = 0; i < niz.length; i++){
            System.out.print (niz[i] + " ");
        }
        
        System.out.println ();
        
        Automobil[] niz2 = new Automobil[3];
        niz2[0] = a1;
        niz2[1] = a2;
        niz2[2] = a3;
        //kako odstampati sve automobile koji su benzin
        for (Automobil a : niz2){
            if (a.getGorivo() == Automobil.VrstaGoriva.BENZIN){
                System.out.println (a.toString());
            }
        }
        
        //sortiranje niza automobila prema kubikazi, da odstampamo najveceg
        bubbleSort (niz2);
        
        System.out.println ("Najveca kubikaza");
        System.out.println (niz2[2].toString());
        
        System.out.println ("Najmanja kubikaza");
        System.out.println (niz2[0].toString());
    }  
    
    public static void bubbleSort(int[] arr) {  
        int n = arr.length;  
        int temp = 0;  
         for(int i=0; i < n; i++){  
                 for(int j=1; j < (n-i); j++){  
                          if(arr[j-1] > arr[j]){  
                                 //swap elements  
                                 temp = arr[j-1];  
                                 arr[j-1] = arr[j];  
                                 arr[j] = temp;  
                         }  
                          
                 }  
         }  
    }
    
    public static void bubbleSort(Automobil[] arr) {  
        int n = arr.length;   
         for(int i=0; i < n; i++){  
                 for(int j=1; j < (n-i); j++){  
                          if(arr[j-1].getMotor().getKubikaza() > arr[j].getMotor().getKubikaza()){  
                                 //swap elements 
                                 Automobil.zameniMesta(arr[j-1], arr[j]);
                                  
                         }  
                          
                 }  
         }  
    }
    
    
}


