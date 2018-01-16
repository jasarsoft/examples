# Serpinski trougao

import turtle

#trougao Serpinskog zadan koordinatama trougla
def trouga(uglovi):
    turtle.color('violet')
    turtle.up()
    turtle.goto(uglovi[0][0], uglovi[0][1])
    turtle.down()
    turtle.goto(uglovi[1][0], uglovi[1][1])
    turtle.goto(uglovi[2][0], uglovi[2][1])
    turtle.goto(uglovi[0][0], uglovi[0][1])

#vraca koordinate sredine stranice izmedju dva ugla
def sredina(u1, u2):
    return [(u1[0] + u2[0])/2, (u1[1]+u2[1])/2]

#rekurzivni prikaz osnovnog i tri manaj trougla
def serpinski(uglovi, dubina):
    trouga(uglovi)
    if dubina > 0:
        serpinski([uglovi[0],
                   sredina(uglovi[0], uglovi[1]),
                   sredina(uglovi[0], uglovi[2])],
                  dubina - 1)
        serpinski([uglovi[1],
                   sredina(uglovi[0], uglovi[1]),
                   sredina(uglovi[1], uglovi[2])],
                   dubina - 1)
        serpinski([uglovi[2],
                   sredina(uglovi[2], uglovi[1]),
                   sredina(uglovi[0], uglovi[2])],
                  dubina - 1)

uglovi = [[-150, -50], [0, 200], [150, -50]]
serpinski(uglovi, 4)

        
