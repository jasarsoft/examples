import turtle
import ops_pred_19_tacka

spisak = [
    ops_pred_19_tacka.Tacka(20, 20),
    ops_pred_19_tacka.Tacka(20, 30),
    ops_pred_19_tacka.Tacka(20, 40),
    ops_pred_19_tacka.Tacka(20, 50),
    ops_pred_19_tacka.Tacka(20, 60),
    ops_pred_19_tacka.Tacka(30, 50),
    ops_pred_19_tacka.Tacka(20, 20),
    ops_pred_19_tacka.Tacka(40, 40),
    ops_pred_19_tacka.Tacka(50, 50),
    ops_pred_19_tacka.Tacka(60, 60),
    ops_pred_19_tacka.Tacka(60, 50),
    ops_pred_19_tacka.Tacka(60, 40),
    ops_pred_19_tacka.Tacka(60, 30),
    ops_pred_19_tacka.Tacka(60, 20)
    ]

c = ops_pred_19_tacka.Tacka(0, 0)

t = turtle.Turtle()
t.up()
t.speed(0)
t.color('green')
t.setpos(c['x'], c['y'])
t.down()
t.forward(1)
t.left(90)
t.down()
t.forward(1)
t.left(90)
t.down()
t.forward(1)
t.left(90)
t.up()
t.color('black')

for s in spisak:
    t.setpos(s['x'], s['y'])
    t.down()
    t.forward(1)
    t.left(90)
    t.down()
    t.forward(1)
    t.left(90)
    t.down()
    t.forward(1)
    t.left(90)
    t.up()

t.setpos(100, 100)
t.color('red')

spisakRotiranih = []
for s in spisak:
    rS = ops_pred_19_tacka.rotiraj(s, c, 45)
    spisakRotiranih.append(rS)

for s in spisakRotiranih:
    t.setpos(s['x']*2, s['y']*2)
    t.down()
    t.forward(1)
    t.left(90)
    t.down()
    t.forward(1)
    t.left(90)
    t.down()
    t.forward(1)
    t.left(90)
    t.up()

t.setpos(100, 100)
