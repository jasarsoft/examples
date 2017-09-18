import math
import cmath

a = 89
b = math.sqrt(a)
print(b)
b = cmath.sqrt(a)
print(b)

# a*X**2 + b*x + c = 0

a = 2
b = 2
c = 2

x1 = (-b + cmath.sqrt(b**2 - 4*a*c)) / (2*a)
x2 = (-b + cmath.sqrt(b**2 - 4*a*c)) / (2*a)
print("X1 = ", x1)
print("X2 = ", x2)

a = 2
b = 20
c = 2

x1 = (-b + math.sqrt(b**2 - 4*a*c)) / (2*a)
x2 = (-b + math.sqrt(b**2 - 4*a*c)) / (2*a)
print("X1 = ", x1)
print("X2 = ", x2)

d = -56.4
e = abs(d)
print(e)

c = (-71 -0.5j)
print(c)

cr = c.real
print(cr)

cr = abs(c.real)
print(cr)

ci = abs(c.imag)
print(ci)

ca = (cr + ci*1j)
print(ca)

ca = (abs(c.real) + abs(c.imag)*1j)
print(ca)

a = (-2 +3j)
b = ( 3 -1j)

c = a + b
print(c)
c = a - b
print(c)
c = a * b
print(c)
c = a / b
print(c)

# Tf = Tc * 1.8 + 32
tC = 24.5
tF = tC * 1.8 + 32
print(tF)

tF = 76.1
tC = (tF - 32) / 1.8
print(tC)
tC = round(tF, 1)
print(tC)

# Lrt = Lcm / 30.48
lcm = 200
lft = lcm / 30.48
print(lft)

# Lmi = Lkm / 1.609345
lkm = 120
lmi = lkm / 1.609345
print(lmi)
