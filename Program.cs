Course programmering = new Course("C# Grundkurs", 5);
Course Biology = new Course("Biologi 1", 3);

Student aldo = new Student("Aldo");
Student ulf = new Student("Ulf");
Student mia = new Student("Mia"); 

Console.WriteLine("Testar om  man kan göra kopplingen från båda hållen samt dubblett ");
programmering.Enroll(aldo); // Kursen lägg till mig 
ulf.JoinCourse(programmering); // Studenten lägger till sig genom student
programmering.Enroll(aldo); // Testar dubblett.

Console.WriteLine("Testar max antalet studenter på kursen");
Student anna = new Student("Anna");
Student roger = new Student("Roger");
Student lisa = new Student("Lisa");
programmering.Enroll(anna);
programmering.Enroll(roger);
programmering.Enroll(lisa);
programmering.Enroll(mia); // Det finns inga plater ledig 



