// Detta kallas för primary constructer och här skapar vi Course.
// För att skicka in namne gör vi detta me string och antalet platser med int.
// eftersom int kontrollerar antal.
class Course(string name, int maxSeats)
{
    // Det vi gör här är att ge koden åtkomst för att läsa och ändra värdet.
    // och detta är fullt synligt så länge vi använder public motsatsen är private
    // Vi får också infon att det är en teststräng
    public string Name = name;

    // Här kan vi bestämma antalet platser i en kurs.
    public int MaxSeats = maxSeats;

    // Här har vi en lista med olika studenter. Just nu är den tom.
    // Men denna lista lik kurslitan kommer att fyllas på allt efterhand.
    public List<Student> students = [];

    // Här kan vi lägga till en student utan att använda JoinCourse
    // och detta gör vi genom att använda funktionen Enroll.
    public bool Enroll(Student studentToEnroll)
    {   // Här kontrolleras antalet lediga platser eller om klassen är fult.
        // Sedan skickas en meddelande om jus detta.
        /* THOMAS ALTERNATIV EARLY RETURN ISTÄLLET FÖR NESTED IF
           VI VÄNDER PÅ VILLKORSLOGIKEN
           - om kursen redan är full -> Early return
           - om studenter redan är med -> Early return
        if(students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen redan full");
            return false;
        }

        if (studentToEnroll.courses.Contains(this))){
            Console.WriteLine("Student already enrolled");
            return false;
        }
        students.Add(studentToEnroll);
        studentToEnroll.courses.Add(this);
        return true;*/
        if (students.Count < MaxSeats)
        {
            //Här skyddar vi oss mot dubbel inskrivning, sammtidigt som Course
            // kontrollerar studentens lista. Utropstekenet kollar att studenten
            // inte har kursen i sin lista.Detta är också ett skydd mot logiska fel.
            if (!studentToEnroll.courses.Contains(this))
            {
                // Om allting är som det ska vara då ska kursen veta om studenten.
                // Och studenten ska veta om kursen och listorna måste uppdateras.
                // Sedan ska studenten läggas till också.
                students.Add(studentToEnroll);
                studentToEnroll.courses.Add(this);
            

                //Meddelar i skärmen att studenten är registrerad  
                // alltsså informerar användaren
                // och returnerar ett värde att registreringen lyckades.
                Console.WriteLine("Studenten är nu registrerad. ");
                return true;
            }
            else
            {   //Meddelar användaren att studenten är redan är registrerad
                Console.WriteLine("Studenten är redan registrerad");
                return false;
            }
        }
        else
        {   //Om if ovanför inte är sant då meddelas detta till användaren
            // att det inte gick bra. Även här returners ett värde i form av att
            // registeringen inte lyckades.
            Console.WriteLine("Tyvärr så finns det inga lediga platser. ");
            return false;
        }  
    
    }
    //Här kontrollerar vi om studenten är registrerad i kursen eller om 
    // kursen finns i studentens lista. Om registeringen är kvar på 
    // någon lista så rensar vi den.+
    public bool UnEnroll(Student studentToLeave)
    {
        // Här kontrolleras att studenten finns i listan och att studenten  
        // inte skriv ut flera gånger
        // Detta är ett skydd för att förhindra logiska fel
        if (students.Contains(studentToLeave) || studentToLeave.courses.Contains(this))
        {
            
            // Tar bort studenten från kursenlista
            students.Remove(studentToLeave);
            studentToLeave.courses.Remove(this);
            
            //Meddelar och infomerar användaren vad som har skett
            // Samt returnerar ett värde att utskrivningen lyckades
            Console.WriteLine("Tyvärr så slutade en student. En plats är ledig. ");
            return true;    
        }
        else
        {   
            //Meddelar och infomerar användaren vad som har skett
            // Samt returnerar ett värde att registreringen misslyckades
            Console.WriteLine("Studenten är ej registrerad i denna kurs. ");
            return false;
        }
    }
    // skriver ut alla studerande i kursen
    public void RollCall()
    {   
        //Det här en loopsom undersöker listan student
        // Den tar en studnet i taget  i det som kallas s.
        foreach (Student s in students)
        {
            // Här skriver man ut studenten s i skärmen/konsolen
            Console.WriteLine(s);
        }
    }   
    // Metoden kan läsas och av andra klasser
    // Eftersom ToString har en fast metod eller standars så säger vi till 
    // den att strunta i den och gör som jag vill istället.
    // Eftersom vi inte har void så vill vi returnera ett värde textsträngar.
    public override string ToString()
    {
        // Här har vi något som kallas för Sränginterpolering $ och gör
        // så att vi kan använda vanlig text med variabler.
        // Här kommer det att skriva ur i konsolen namet på kursen 
        // antalet studenter som är registrerade och visa antalet platser 
        // kursen har total allt detta kommer användaren kunna se.
        return $"{Name}, ({students.Count} / {MaxSeats} platser)";
    }

}

