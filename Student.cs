using System.Runtime.InteropServices;

//Här skapar vi en student och detta kallas för primär kostruktör
// för att skicka in namnet så måste detta göras genon en textsträng.
class Student(string name)
{    
    // Det vi gör här är att ge koden åtkomst för att läsa och ändra värdet.
    // och detta är fullt synligt så länge vi använder public motsatsen är private
    // String bärettar att detta kopmmer att vara en textsträng
    // Tills sist så sparas namnet på studenten. Jag kan skriva ut namnet.
    public string Name = name;
    

    // Här skapar vi en lista på olika kurser, Just nu är den tom
    // Men denna lista kan vi fylla på allt efterhand.
    public List<Course> courses = [];

        //Detta betyder att vi kan starta anropa metoden.
        // Men eftersom vi har använt void så returnerar metoden ingeting.
        //JoinCourse är själva metoden medan (Course coursesToJoin) är indata.
        public void JoinCourse(Course coursesToJoin)
    {
        // if med utropstecken kontrolerar om kursen finns och att man inte kan 
        // gå med i samma kurs flera gånger.
        if (!courses.Contains(coursesToJoin))
        {
            //Här läggs kursen till stdentens lisa 
            // och sedan meddelar man kursen att studenten har gått med
            courses.Add(coursesToJoin);
            coursesToJoin.Enroll(this);
        }
    }
    
    public void LeaveCourse(Course coursesToLeave)
    {
        if (courses.Contains(coursesToLeave))
        {
            courses.Remove(coursesToLeave);
            coursesToLeave.UnEnroll(this);
        }
    }
    public void ScheduleCourse()
    {
        foreach (Course c in courses)
        {
           Console.WriteLine(c.Name);
        }
    }
    public override string ToString()
    {
        return Name;
    }

}



