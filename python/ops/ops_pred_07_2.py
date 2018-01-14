for a in range(1, 11, 1):
    for b in range(1, 11, 1):
        c = a * b
        # 15
        # repr(15).rjust(4)
        # __15

        # 105
        # repr(105).rjust(10)
        # _______105
        print(repr(c).rjust(4), end=" |")
    print()

