#lambda forme

tacke = [{'x' : 2, 'y' : 3}, {'x' : 4, 'y' : 1}]
print(tacke)
tacke.sort(key = lambda i : i['y'])
print(tacke)
