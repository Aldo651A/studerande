using System.Runtime.InteropServices;

//Här skapar vi en student och detta kallas för primär kostruktör
// för att skicka in namnet så måste detta göras genon en textsträng.
class Student(string name string course)
{    
    // Det vi gör här är att ge koden åtkomst för att läsa och ändra värdet.
    // och detta är fullt synligt så länge vi använder public motsatsen är private
    // String bärettar att detta kopmmer att vara en textsträng
    // Tills sist så sparas namnet på studenten. Jag kan skriva ut namnet.
    public string Name = name;
    

    // Här skapar vi en lista på olika kurser, Just nu är den tom
    // Men denna lista kan vi fylla på allt efterhand.
    public List<Courses> courses = [];

    //Denna raden gör att vi kan anmälla eleven till en kurs.
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
        if (courses.Contains(courseToLeave))
        {
            courses.Remove(courseToLeave);
            coursesToLeave.Enroll(this);
        }
    }
    public void ScheduleCourse(Course courseToScheudle)
    {
        foreach (Course c in course)
        {
            
        }
    }

}



