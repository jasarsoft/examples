# pronalazenje najblize tacke u ravni
# linearno pretrazivanje
import math

def euklid(x, y):
    return math.sqrt((x[0]-y[0])**2+(x[1]-y[1])**2)

tacke = [[-1, 3],   [-1, -1],   [1, 1], [2, 0.5],
         [2, -1],   [3, 3],     [4, 2], [4, -0.5]]

zadana = [2,2]
najbliza = tacke[0]
mind = euklid(zadana, najbliza)
for i in range(1, len(tacke)):
    d = euklid(zadana, tacke[i])
    if d < mind:
        najbliza = tacke[i]
        mind = d

print("Najbliza tacka tacki ", zadana, " je ", najbliza, " udaljena ", mind)
