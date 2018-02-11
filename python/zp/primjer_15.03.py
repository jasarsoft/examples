import time

try:
    f = open("pjesma.txt")
    while True: #nas uobicajni nacin citanja fajlova
        linija = f.readline()
        if len(linija) == 0:
            break
        print(linija, end = " ")
        time.sleep(2) #da budemo sigurni da ce da radi neko vrijeme
except KeyboardInterrupt:
    print("!! Vi ste prekinuli citanje fajla")
finally:
    f.close()
    print("(Cisitmo: zatvarmo fajl)")
    
