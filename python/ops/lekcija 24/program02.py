import json

datoteka = open("student.json", "r")
studentJson = datoteka.read()
student = json.loads(studentJson)
print(student["ispiti"][0]["predmet"])
