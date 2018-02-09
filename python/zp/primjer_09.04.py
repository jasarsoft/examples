x = 50

def funk():
    global x

    print("x je ", x)
    x = 2
    print("Promjena globalne vrijednost promjeljive x na ", x)

funk()
print("Vrijednost promjeljive x sada je ", x)
