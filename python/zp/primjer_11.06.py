bri = set(['brazil', 'rusija', 'indija'])

print('indija' in bri)
print('usa' in bri)

brik = bri.copy()
brik.add('kina')
print(brik.issuperset(bri))

bri.remove('rusija')
print(bri & brik) #ili bri.intersection(brik)

