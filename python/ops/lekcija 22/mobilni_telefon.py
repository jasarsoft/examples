import ekran_telefona

def MobilniTelefon(proizvodjac, model, godina, memorijaRAM, memorijaDisk, ekran):
    if type(ekran) != dict:
        return -1

    for kljuc in ekran.keys():
        if kljuc not in ['sirina', 'visina']:
            return -1
        
    return {
        'proizvodjac'   : proizvodjac,
        'model'         : model,
        'godina'        : godina,
        'memorijaRAM'   : memorijaRAM,
        'memorijaDisk'  : memorijaDisk,
        'ekran'         : ekran
        }

def ocjenaPodobnosti(mt):
    dijagonala = ekran_telefona.dijagonala(mt['ekran'])

    if dijagonala < 5:
        return dijagonala * mt['memorijaRAM'] / (2020-mt['godina'])
    else:
        return dijagonala * mt['memorijaDisk'] / (2020 - mt['godina'])


