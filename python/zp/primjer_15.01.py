try:
    tekst = input("Ukucaj nesto --> ")
except EOFError:
    print("Zasto si mi uradio EOF?")
except KeyboardInterrupt:
    print("Ti si ponistio operaciju.")
else:
    print("Ti si unio {0}".format(tekst))
