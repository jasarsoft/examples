class Licnost:
    def __init__(self, ime):
        self.ime = ime
    def kaziZdravo(self):
        print("Zdravo ja se zovem", self.ime)

L = Licnost("Swaroop")
L.kaziZdravo()

#ovaj kratiki primjer se takod moze napisati kao
Licnost("Swaroop").kaziZdravo()
