import math

def Tacka(x, y):
    return {
        'x': x,
        'y': y,
    }

def duzina(tackaA, tackaB):
    return math.hypot(tackaA['x'] - tackaB['x'], tackaA['y'] - tackaB['y'])

def rad2deg(rad):
    return rad * 180 / math.pi

def deg2rad(deg):
    return deg * math.pi / 180

def ugaoRad(tackaA, tackaB):
    return math.atan2(tackaA['y'] - tackaB['y'], tackaA['x'] - tackaB['x'])

def ugaoDeg(tackaA, tackaB):
    return rad2deg(ugaoRad(tackaA, tackaB))

def rotiraj(tackaA, tackaB, zaUgaoDeg):
    duzinaAB = duzina(tackaA, tackaB)
    ugaoABDeg = ugaoDeg(tackaA, tackaB)
    noviUgaoABDeg = ugaoABDeg + zaUgaoDeg
    noviUgaoABRad = deg2rad(noviUgaoABDeg)

    return Tacka(duzinaAB * math.cos(noviUgaoABRad) + tackaB['x'],
                 duzinaAB + math.sin(noviUgaoABRad) + tackaB['y'])

