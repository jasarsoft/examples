Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> "Heksadecimalni zapis broja %d je %X" % (77, 77)
'Heksadecimalni zapis broja 77 je 4D'
>>> "Vrijednost %d/%d je %5.3f" % (1, 3, 1/3)
'Vrijednost 1/3 je 0.333'
>>> format(1/3, "10.3f")
'     0.333'
>>> "Vrijednost {0}/{1} je {2}".format(1, 3, 1/3)
'Vrijednost 1/3 je 0.3333333333333333'
>>> "Vrijednost {0}/{1} je {2:5.3f}".format(1, 3, 1/3)
'Vrijednost 1/3 je 0.333'
>>> ime = "Milan"
>>> f"Moje ime je {ime!r}."
"Moje ime je 'Milan'."
>>> sirina = 10
>>> cifara = 5
>>> broj = float("12.34587")
>>> f"rezultat: {broj:{sirina}.{cifara}}"
'rezultat:     12.346'
>>> ime = {"ime":"Petar", "prezime":"Petrovic"}
>>> rec = {"ime":ime, "polozaj":["razvoj", "manadzer"], "starost":40.5}
>>> rec
{'ime': {'ime': 'Petar', 'prezime': 'Petrovic'}, 'polozaj': ['razvoj', 'manadzer'], 'starost': 40.5}
>>> import json
>>> json.dump(rec, fp=open("podaci_json.txt", "w"), indent=4)
>>> print(open("podaci_json.txt").read())
{
    "ime": {
        "ime": "Petar",
        "prezime": "Petrovic"
    },
    "polozaj": [
        "razvoj",
        "manadzer"
    ],
    "starost": 40.5
}
>>> P = json.load(open("podaci_json.txt"))
>>> P
{'ime': {'ime': 'Petar', 'prezime': 'Petrovic'}, 'polozaj': ['razvoj', 'manadzer'], 'starost': 40.5}
>>> import urllib.request
f
>>> f=urllib.request.urlopen("https://docs.python.org/3/index.html")
>>> print(htmltekst[0:123])
Traceback (most recent call last):
  File "<pyshell#21>", line 1, in <module>
    print(htmltekst[0:123])
NameError: name 'htmltekst' is not defined
>>> htmltekst = f.read().decode()
>>> print(htmltekst[0:123])

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"
>>> URL = "http://api.fixer.io/latest?base=" + <o_valuta>
SyntaxError: invalid syntax
>>> URL = "http://api.fixer.io/latest?base=" + "USD"
>>> odgovor = urllib.request.urlopen(URL).read()
>>> recnik = json.loads(odgovor)
>>> recnik1 = recnik["rates"]
>>> recnik1
{'AUD': 1.2575, 'BGN': 1.5992, 'BRL': 3.2137, 'CAD': 1.2424, 'CHF': 0.96443, 'CNY': 6.4415, 'CZK': 20.863, 'DKK': 6.0909, 'GBP': 0.72657, 'HKD': 7.8234, 'HRK': 6.0699, 'HUF': 252.45, 'IDR': 13338.0, 'ILS': 3.415, 'INR': 64.047, 'JPY': 110.71, 'KRW': 1064.9, 'MXN': 18.773, 'MYR': 3.9649, 'NOK': 7.8747, 'NZD': 1.3743, 'PHP': 50.645, 'PLN': 3.4107, 'RON': 3.8007, 'RUB': 56.439, 'SEK': 8.0317, 'SGD': 1.3234, 'THB': 31.98, 'TRY': 3.797, 'ZAR': 12.262, 'EUR': 0.81766}
>>> koeficijent = recnik[uValutu]
Traceback (most recent call last):
  File "<pyshell#30>", line 1, in <module>
    koeficijent = recnik[uValutu]
NameError: name 'uValutu' is not defined
>>> recnik
{'base': 'USD', 'date': '2018-01-16', 'rates': {'AUD': 1.2575, 'BGN': 1.5992, 'BRL': 3.2137, 'CAD': 1.2424, 'CHF': 0.96443, 'CNY': 6.4415, 'CZK': 20.863, 'DKK': 6.0909, 'GBP': 0.72657, 'HKD': 7.8234, 'HRK': 6.0699, 'HUF': 252.45, 'IDR': 13338.0, 'ILS': 3.415, 'INR': 64.047, 'JPY': 110.71, 'KRW': 1064.9, 'MXN': 18.773, 'MYR': 3.9649, 'NOK': 7.8747, 'NZD': 1.3743, 'PHP': 50.645, 'PLN': 3.4107, 'RON': 3.8007, 'RUB': 56.439, 'SEK': 8.0317, 'SGD': 1.3234, 'THB': 31.98, 'TRY': 3.797, 'ZAR': 12.262, 'EUR': 0.81766}}
>>> 
