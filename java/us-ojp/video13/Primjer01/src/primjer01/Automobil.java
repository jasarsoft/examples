package primjer01;


public class Automobil {
    private double rezervoar = 0.0;
    private double predjeniKilometri = 0.0;
    
    private double predjenaKilometrazaKodPosljednjeDopune = 0.0;
    private double stanjeRezervoaraKodPosljenjeDopune = 0.0;
    private double iznosPosljednjeDopuneRezervoara = 0.0;
    
    public double getRezerovar(){
        return rezervoar;
    }
    
    public double getPredjenaKilometraza(){
        return predjeniKilometri;
    }
    
    public void dopuniGorivo(double kolicina) {
        stanjeRezervoaraKodPosljenjeDopune = rezervoar;
        predjenaKilometrazaKodPosljednjeDopune = predjeniKilometri;
        
        rezervoar += kolicina;
        
        iznosPosljednjeDopuneRezervoara = kolicina;
    }
    
    public void voziPoGradu(double put) {
        predjeniKilometri += put;
        rezervoar -= (put / 100.0) * 7.0;
    }
    
    public void voziNaOtvorenom(double put) {
        predjeniKilometri += put;
        rezervoar -= (put / 100.0) * 5.6;
    }
    
    public double prosjenaPotrosnjaPosljednjeDopune() {
        double predjeniPut, potrosnoGorivo;
        
        predjeniPut = predjeniKilometri - predjenaKilometrazaKodPosljednjeDopune;
        potrosnoGorivo = (stanjeRezervoaraKodPosljenjeDopune + iznosPosljednjeDopuneRezervoara) - rezervoar;
        
        return (potrosnoGorivo * 100.0) / predjeniPut;
    }
}
