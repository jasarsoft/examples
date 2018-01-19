koordinate = {}

koordinate[(10, 20, 30)] = 15.4
koordinate[(10, -5, 11)] = 20.0

print(koordinate)
print(koordinate[(10, 20, 30)])

print(koordinate.keys())

if (10, 20, 30) in koordinate.keys():
    print(koordinate[(10, 20, 30)])

    
