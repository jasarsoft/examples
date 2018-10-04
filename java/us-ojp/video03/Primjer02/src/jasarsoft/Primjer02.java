
package jasarsoft;

public class Primjer02 {

    public static void main(String[] args) {
        
        int godinaRodjenjaStudenta;
        int godinaRodjenjaProfesora = 1981;
        
        godinaRodjenjaStudenta = 1988;
        
        int razlikaUGodinama = godinaRodjenjaStudenta - godinaRodjenjaProfesora;
        
        System.out.print("Razlika u godinama je ");
        System.out.println(razlikaUGodinama);
        
        String poruka = "Razlika u godinama je " + razlikaUGodinama + ".";
        
        System.out.println(poruka);
    }
    
}
