#program za crtanje faktalnog stabla zadane duzine

import turtle

def fraktalnoStablo(f_duzina, min_duzina = 10):
    #fukcija rezukzivno crta stablo s dva lista
    turtle.forward(f_duzina)
    if f_duzina > min_duzina:
        turtle.left(45)
        fraktalnoStablo(0.6*f_duzina, min_duzina)
        turtle.right(90)
        fraktalnoStablo(0.6*f_duzina, min_duzina)
        turtle.left(45)
    turtle.back(f_duzina)

turtle.left(90)
fraktalnoStablo(100)
