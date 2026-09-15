Course programmering = new Course("C# Grundkurs", 5);
Course Mathematic = new Course("Math 2", 4);
Course Biology = new Course("Bioologi 1", 3);

Student aldo = new Student("Aldo"); // Här lägger jag in studenten
Student ulf = new Student("Ulf");
Student anna = new Student("Anna");
Student roger = new Student("Roger");
Student lisa = new Student("Lisa");
Student mia = new Student("Mia"); // Kommer inte att får plats i kursen

aldo.JoinCourse(programmering); // Här går studenterna med i kursen
ulf.JoinCourse(programmering);
anna.JoinCourse(programmering);
roger.JoinCourse(programmering);
programmering.Enroll(lisa); // Terstar att Enroll registrerar student.
programmering.Enroll(mia);  // Terstar att Enroll registrerar student

ulf.JoinCourse(Biologi);

aldo.JoinCourse(Mathematic);
Mathematic.Enroll(anna);


aldo.JoinCourse(programmering); // här lägger jag in en dubblet

programmering.UnEnroll(ulf); // Testar om student avregistreras med UnEnroll.

lisa.LeaveCourse(programmering); // testar om det går att avregistrera sig med LeaveCourse.

aldo.ScheduleCourse(); //Skriver ut vilka kursen den studerande går.
anna.ScheduleCourse();
ulf.ScheduleCourse();

programmering.RollCall(); // Skriver ut en lista på dem som studerar i kursen.
Console.WriteLine(programmering); // Visar hur många platser är upptagna eller tillgängliga.

