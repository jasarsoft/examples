x = 50

def funk(x):
    print("x je ", x)
    x = 2
    print("Promjenili smo lokalnu vrijednost x na ", x)

funk(x)
print("x je jos uvijek", x)
