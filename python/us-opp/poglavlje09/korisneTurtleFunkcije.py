""" Modul korisne TurtleFunkcije.

    Funkcije za crtanje linije, tacke, kruznice, pravugaonika
    i ispis teksta pomocu funkcija iz modula Turtle.

"""

import turtle

# crtanje linije (x1, y1) to (x2, y2)
def drawLine(x1, y1, x2, y2):
    turtle.penup()      #podizanje pera
    turtle.goto(x1, y1)
    turtle.pendown()    #spustanje pera
    turtle.goto(x2, y2)

# ispis teksta od koordinata (x, y)
def writeText(s, x, y):
    turtle.penup()      #podizanje pera
    turtle.goto(x, y)
    turtle.pendown()    #spustanje pera
    turtle.write(s)     #ispis teksta

# crtanje tacke na koordinatama (x, y)
def drawPoint(x, y):
    turtle.penup()      #podizanje pera
    turtle.goto(x, y)
    turtle.pendown()    #spustanje pera
    turtle.begin_fill() #pocetak popunjavanja
    turtle.circle(3)
    turtle.end_fill()   #popunjavanje oblika

# crtanje kruga zadanog poluprecnika s centrom u (x, y)
def drawCircle(x = 0, y = 0, radius = 10):
    turtle.penup()      #podizanje pera
    turtle.goto(x, y - radius)
    turtle.pendown()    #spustanje pera
    turtle.circle(radius)

# crtanje pravugaonika zadatih dimenzija od (x, y)
def drawRectangle(x = 0, y = 0, width = 10, height = 10):
    turtle.penup()      #podizanje pera
    turtle.goto(x + width/2, y + height/2)
    turtle.pendown()    #spustanje pera
    turtle.right(90)
    turtle.forward(height)
    turtle.right(90)
    turtle.forward(width)
    turtle.right(90)
    turtle.forward(height)
    turtle.right(90)
    turtle.forward(width)
    
