package liste;

import java.util.ArrayList;

public class PrimerListe {

    public static void main(String[] args) {

        //lista stringova
        ArrayList<String> listStrings = new ArrayList<String>();
        System.out.println(listStrings.size());
        listStrings.add("Jedan");
        listStrings.add("Dva");
        listStrings.add("Tri");
        listStrings.add("Cetiri");

        System.out.println(listStrings);
        System.out.println(listStrings.size());
        
        //uklanjamo element na poziciji 2
        listStrings.remove(2);

        System.out.println(listStrings);
        System.out.println(listStrings.size());
        
        //uklanjanje svih elemenata iz liste
        listStrings.clear();
        System.out.println(listStrings.size());

        //kreiranje nove liste
        ArrayList<Object> listaBiloSta = new ArrayList<>();
        ArrayList<String> listaStringova = new ArrayList<>();
        ArrayList<Integer> listaBrojeva = new ArrayList<Integer>();

        //od Java 7 tip parametra sa desne strane se moze izostaviti
        ArrayList<Integer> listaBrojeva2 = new ArrayList<>();

        //po defaultu se pravi lista kapaciteta 10
        //ukoliko je poznato, mozemo specificirati pocetni kapacitet liste
        ArrayList<Integer> listNumbers = new ArrayList<>(1000);

        //Lista klasnog tipa radnik
        ArrayList<Radnik> listaRadnika = new ArrayList<>();

        //dodavanje radnika
        listaRadnika.add(new Radnik("Pera Peric", 123321, 10, 1000));

        Radnik radnik = new Radnik("Jovan Jovanovic", 1233314, 5, 1500);
        listaRadnika.add(radnik);

        listaRadnika.add(new Radnik("Luka Lukic", 1246434, 7, 1200));

        //stampanje liste
        System.out.println("Broj radnika u listi radnika " + listaRadnika.size());
        System.out.println("Radnici u listi " + listaRadnika);

        //insert novog radnika na tacnu poziciju
        listaRadnika.add(1, new Radnik("Mika Mikic", 542020, 3, 800));

        //stampanje liste nakon inserta
        System.out.println("Broj radnika u listi radnika " + listaRadnika.size());
        System.out.println("Radnici u listi " + listaRadnika);

        //izbacivanje odredjenog radnika iz liste (npr onog koji ima staz veci od 9 godina)
        for (int i = 0; i < listaRadnika.size(); i++) {
            if (listaRadnika.get(i).getStaz() > 9) {
                listaRadnika.remove(i);
                i--;
            }
        }

        //stampanje liste nakon inserta
        System.out.println("Broj radnika u listi radnika " + listaRadnika.size());
        System.out.println("Radnici u listi " + listaRadnika);

    }

}
