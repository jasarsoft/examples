import json

datoteka = open("student.json", "r")
student = json.load(datoteka)
datoteka.close()

print(student)
