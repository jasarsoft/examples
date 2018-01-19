import turtle

t = turtle.Turtle()

t.speed(1)
t.color("green")
t.left(90)
t.backward(150)

ugao = 30.0
najkraca = 10
procenatGrane = 0.6

def grana(n):
    if n >= najkraca:
        t.forward(n)

        t.right(ugao)
        grana(n*procenatGrane*0.8)

        t.left(ugao)
        grana(n*procenatGrane)

        t.left(ugao)
        grana(n*procenatGrane*0.8)

        t.right(ugao)
        t.backward(n)

grana(150)
