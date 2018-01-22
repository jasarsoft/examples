import ops_pred_21_racun
import ops_pred_21_stavka

r = ops_pred_21_racun.Racun("Radnja One", "Nepoznata 33", "Beograd", "2016-12-08", "12:00:00", "Milan")

ops_pred_21_racun.dodajStavku(r, ops_pred_21_stavka.Stavka("Proizvod 1", 300.56))
ops_pred_21_racun.dodajStavku(r, ops_pred_21_stavka.Stavka("Proizvod 2", 30.56))
ops_pred_21_racun.dodajStavku(r, ops_pred_21_stavka.Stavka("Proizvod sa duzim imenom", 5000.56))
ops_pred_21_racun.dodajStavku(r, ops_pred_21_stavka.Stavka("Kokice", 120.00))
ops_pred_21_racun.dodajStavku(r, ops_pred_21_stavka.Stavka("Papir A4", 599.99))

ops_pred_21_racun.prikaziRacun(r, 30)
