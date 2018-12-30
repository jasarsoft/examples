package primjer01;

public class Primjer01 {

    public static void main(String[] args) {
        Veverica v1 = new Veverica("Chip", "braun");
        
        v1.savijLevuRuku();
        v1.savijDesnuRuku();
        
        v1.pridrzi("LESNJAK");
        v1.ispruziLevuRuku();
        System.out.println(v1.getStaDrzi());
    }
    
}
