Course programmering = new Course("C# Grundkurs", 5);

Student aldo = new Student("Aldo");
Student ulf = new Student("Ulf");
Student anna = new Student("Anna");
Student roger = new Student("Roger");
Student lisa = new Student("Lisa");
Student mia = new Student("MIOA");

aldo.JoinCourse(programmering);
ulf.JoinCourse(programmering);
anna.JoinCourse(programmering);
roger.JoinCourse(programmering);

programmering.Enroll(lisa);
programmering.Enroll(mia);

aldo.JoinCourse(programmering);

programmering.RollCall();
Console.WriteLine(programmering);

