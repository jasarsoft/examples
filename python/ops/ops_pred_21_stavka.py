
def Stavka(naziv, cijena):
    return {
        'naziv' : naziv,
        'cijena': cijena
        }

def stampajStavku(stavka, sirinaPapira):
    mjestaZaNaziv = sirinaPapira - 13

    nazivZaStampu = stavka['naziv']
    if len(nazivZaStampu) > mjestaZaNaziv:
        nazivZaStampu = nazivZaStampu[0:mjestaZaNaziv-3] + "..."

    print(("{0:" + str(mjestaZaNaziv) + "s} {1:12.2f}").format(nazivZaStampu, stavka['cijena']))
    
