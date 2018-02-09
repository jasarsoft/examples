while True:
    s = input("Ukucaj nesto: ")
    if s == "izlaz":
        break
    if len(s) < 3:
        print("Previse je kratko.")
        continue
    print("Input je zadovoljavajuce duzine.")
    #mozete zadavati druge komande za neki rad ovdej
