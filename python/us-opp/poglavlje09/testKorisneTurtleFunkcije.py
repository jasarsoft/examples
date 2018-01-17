""" Testni program za modul korisneTurtleFunkcije.

    Crta liniju, tacku, kruznicu, pravugaonik i ispisuje
    tekst pomocu funkcija iz modula korisneTurtleFunkcije.

"""

import turtle
from korisneTurtleFunkcije import *

# crtanje linije izmedju (-80. 80) i (80, 80)
drawLine(-80, -80, 80, 80)

# crtanje teksta od (-40, -60)
writeText("Test korisnih Turtle funkcija", -40, -60)

# crtanje tacke u (0, 0)
drawPoint(0, 0)

# crtanje kruznice poluprecnika 113 od (0,0)
drawCircle(0, 0 , 113)

# crtanje pravouganika 100x50 od (0, 0)
drawRectangle(0, 0, 100, 50)

turtle.hideturtle()
turtle.done()
