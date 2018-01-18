class Student:
    def __str__(self):
        return "Student"

    def printStudent(self):
        print(self.__str__())


class DiplomiraniStudent(Student):
    def __str__(self):
        return "Diplomirani student"

a = Student()
b = DiplomiraniStudent()

a.printStudent()
b.printStudent()
