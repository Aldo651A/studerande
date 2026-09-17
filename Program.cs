Course programmering = new Course("C# Grundkurs", 5);
Course Biology = new Course("Biologi 1", 3);

Student aldo = new Student("Aldo");
Student ulf = new Student("Ulf");
Student mia = new Student("Mia"); 

Console.WriteLine("Testar om man kan gå med i kursen och dubblet skydd");
programmering.Enroll(aldo); // Kursen lägg till mig 
ulf.JoinCourse(programmering); // Studenten lägger till sig genom student
programmering.Enroll(aldo); // Testar dubblett.

