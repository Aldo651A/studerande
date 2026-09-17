Course programmering = new Course("C# Grundkurs", 5);
Course Mathematic = new Course("Math 2", 4);
Course Biology = new Course("Biologi 1", 3);

Student aldo = new Student("Aldo"); // Här lägger jag in studenten
Student ulf = new Student("Ulf");
Student anna = new Student("Anna");
Student roger = new Student("Roger");
Student lisa = new Student("Lisa");
Student mia = new Student("Mia"); // Kommer inte att får plats i kursen

programmering.Enroll(mia);  // Terstar att Enroll registrerar student

programmering.Enroll(lisa);
programmering.Enroll(lisa);

aldo.JoinCourse(programmering); // Här går studenterna med i kursen
ulf.JoinCourse(programmering);
anna.JoinCourse(programmering);
roger.JoinCourse(programmering);
programmering.Enroll(lisa); // Terstar att Enroll registrerar student.

ulf.JoinCourse(Biology);

programmering.UnEnroll(mia);
programmering.UnEnroll(mia);

aldo.JoinCourse(Mathematic);
Mathematic.Enroll(anna);


aldo.JoinCourse(programmering); // här lägger jag in en dubblet

programmering.UnEnroll(ulf); // Testar om student avregistreras med UnEnroll.



Console.WriteLine("\nAldo's course:");
aldo.ScheduleCourse(); //Skriver ut vilka kursen den studerande går.
Console.WriteLine("\nAnna's course:");
anna.ScheduleCourse();
Console.WriteLine("\nUlf's course:");
ulf.ScheduleCourse();



Console.WriteLine("\nAlla studenter på programmingkursen:");
programmering.RollCall(); // Skriver ut en lista på dem som studerar i kursen.
Console.WriteLine(programmering); // Visar hur många platser är upptagna eller tillgängliga.
Console.WriteLine(Mathematic);
