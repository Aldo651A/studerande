using System.Runtime.InteropServices;

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
programmering.Enroll(anna);  // kursen läger til Anna.
programmering.Enroll(roger); // kursen lägger till Roger.
programmering.Enroll(lisa);  // kursen lägger till Lisa
programmering.Enroll(mia);   // Det finns inga plater ledig 

Console.WriteLine("Tar bort student som inte var anmäld systemet ska inte krascha");
programmering.UnEnroll(mia);
ulf.LeaveCourse(programmering); // Ulf slutar kursen 


