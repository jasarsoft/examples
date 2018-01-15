# 1 argument - temp u *C
# vraca vrijednost - temp u *F
# ima ime: c2f

def c2f(tempC):
    return 1.8 * tempC + 32

def f2c(tempF):
    return (tempF - 32.0) / 1.8

t1C = 34
t2F = 92

t1F = c2f(t1C)
t2C = f2c(t2F)

print(t1F)
print(t2C)

print(c2f(22))
