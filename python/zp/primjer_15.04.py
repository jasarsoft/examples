import time

with open("pjesma.txt") as f:
    for linija in f:
        print(linija, end = " ")
        time.sleep(2) #da budemo sigurni da ce da radi neko vrijeme
