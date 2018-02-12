def sumastepena(stepen, *argumenti):
    '''Vraca sumu svih argumenata stepenovanih na specijalni broj'''
    totalno = 0
    for i in argumenti:
        totalno += pow(i, stepen)

    return totalno

print(sumastepena(2, 3, 4))
print(sumastepena(2, 10))
