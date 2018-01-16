#Kohova kriva (snowflake)

import turtle

#Kohova kriva
def koch(f_duzina, dubina):
    if dubina > 0:
        for ugao in [60, -120, 60, 0]:
            koch(f_duzina/3, dubina-1)
            turtle.left(ugao)
    else:
        turtle.forward(f_duzina)

#test
velicina = 400
dubina = 3

#centriranje pahuljice
turtle.penup()
turtle.backward(velicina/1.73)
turtle.left(30)
turtle.pendown()

#tri Kohove krive
for i in range(3):
    koch(velicina, dubina)
    turtle.right(120)
