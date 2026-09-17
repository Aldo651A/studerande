Console.Clear();

Course programmering = new Course("C# Grundkurs", 5);
Course biologi = new Course("Biologi 1", 3);

Student aldo = new Student("Aldo");
Student ulf = new Student("Ulf");
Student mia = new Student("Mia"); 

Console.WriteLine("Testar om  man kan göra kopplingen från båda hållen samt inte skriva dubblett ");
programmering.Enroll(aldo); // Kursen lägg till mig 
ulf.JoinCourse(programmering); // Studenten lägger till sig genom student
programmering.Enroll(aldo); // Testar dubblett.

Console.WriteLine("\nTestar max antalet studenter på kursen");
Student anna = new Student("Anna"); 
Student roger = new Student("Roger");
Student lisa = new Student("Lisa");
programmering.Enroll(anna);  // kursen läger til Anna.
programmering.Enroll(roger); // kursen lägger till Roger.
programmering.Enroll(lisa);  // kursen lägger till Lisa
programmering.Enroll(mia);   // Det finns inga plater ledig 

Console.WriteLine("\nTar bort student som inte var anmäld systemet ska inte krascha");
programmering.UnEnroll(mia);
ulf.LeaveCourse(programmering); // Ulf slutar kursen 

Console.WriteLine("\nOm man kan gå med i kursen biologi");
biologi.Enroll(anna);  // kursen läger til Anna.
biologi.Enroll(roger); // kursen lägger till Roger.
biologi.Enroll(lisa);


Console.WriteLine("\nkontrollerar vilka kurser lisa och aldo går i");
aldo.ScheduleCourse();
lisa.ScheduleCourse();

Console.WriteLine("\nskriver ut alla studerande i kurserna programmering ");
programmering.RollCall();
Console.WriteLine(programmering);

Console.WriteLine("\nskriver ut studerande i biologi");
biologi.RollCall();
Console.WriteLine(biologi);

Console.WriteLine($"\nStudentens namn är {aldo}");


Console.WriteLine(aldo);
