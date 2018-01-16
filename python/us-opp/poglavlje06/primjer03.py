import turtle
turtle.color('red')
crtaj = True
while crtaj:
    turtle.forward(200)
    turtle.left(170)
    crtaj = abs(turtle.position()) >= 1

