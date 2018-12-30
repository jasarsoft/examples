
package primjer02;

import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesi registarsku oznaku: ");
        String regOznaka = s.nextLine();
        
        if (ispravnaRegistarskaTablica(regOznaka)) {
            System.out.println("Tablica je ispravna.");
        } else {
            System.out.println("Tablica nije ispravna.");
        }
    }
    
    
    public static boolean ispravnaRegistarskaTablica(String tablica) {
        if (tablica.length() != 9) return false;
        
        if (!daLiJeDozvoljenoSlovo(tablica.charAt(0)) || !daLiJeDozvoljenoSlovo(tablica.charAt(1)) || !daLiJeDozvoljenoSlovo(tablica.charAt(7)) || !daLiJeDozvoljenoSlovo(tablica.charAt(8))) {
            return false;
        }
        
        if (!Character.isDigit(tablica.charAt(3)) || !Character.isDigit(tablica.charAt(4)) || !Character.isDigit(tablica.charAt(5))) {
            return false;
        }
        
        if (tablica.charAt(2) != '-' || tablica.charAt(6) != '-') {
            return false;
        }
        
        return true;
    }
    
    public static boolean daLiJeDozvoljenoSlovo(char slovo) {
        if (slovo == 'A' || slovo == 'B' || slovo == 'C' || slovo == 'D' || slovo == 'E' || slovo == 'F' || slovo == 'G'
                 || slovo == 'H' || slovo == 'I' || slovo == 'J' || slovo == 'K' || slovo == 'L' || slovo == 'M' || slovo == 'N'
                 || slovo == 'O' || slovo == 'P' || slovo == 'R' || slovo == 'S' || slovo == 'T' || slovo == 'U' || slovo == 'V'
                 || slovo == 'W' || slovo == 'X' || slovo == 'Z' || slovo == 'Š' || slovo == 'Đ' || slovo == 'Č' || slovo == 'Ć'
                 || slovo == 'Ž')
            return true;
        else
            return false;
    }
}
