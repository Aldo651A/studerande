using System.Runtime.InteropServices;

//Här skapar vi en student och detta kallas för primär kostruktör
// för att skicka in namnet så måste detta göras genon en textsträng.
class Student(string name)
{    
    //Public möjliggör för andra klaser att läsa/ändra värdet.
    //Motsatsen til public är privat. String iformerar att det är en textsträng
    //Man tar emott ett värde "name" från konstruktören och sparar den i fältet "Name"
    // Raden här under skapar en bro mellam primary conductor och resten av programmet.
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
            // Här kontrollerar metoden om studenten får plats
            // och om stdenten redan går kursen
            // När detta har kontrollerat skickas ett svar tillbaka som true/false
            bool fickViPlats = coursesToJoin.Enroll(this);

            // Här sparas svaret från ovan true/false
            // Ifall studenten lyckas registrera sig blir det true 
            // om inte false
            if (fickViPlats)
            {  
                // Skriver ut i konsolens så att användaren ser vad som har hämnt.
                Console.WriteLine("Grattis, du är antagen ");
            }
            else
            {
                // om det är false så så får han meddelandet här nedanför.
                Console.WriteLine("Tyvärr du kom inte in, kursen är fulltsatt. ");
            }
        }
                 
    }
    //Detta betyder att vi kan starta anropa metoden från andra klasser
    // Men eftersom vi har använt void så returnerar metoden ingeting när vi anropar den.
    // LeaveCourse är själva funktionen. (Course coursesToLeave) är indata.
    public void LeaveCourse(Course coursesToLeave)
    {
        
        // Här kontrolleras if satsen om kursen fins innan den raderas.
        if (courses.Contains(coursesToLeave))
        {
            //Här ta man bort kursen från studentens listan. 
            courses.Remove(coursesToLeave);
            // Här meddelar man kursen att ta bort studenten.
            coursesToLeave.UnEnroll(this);
        }
    }
    // Detta betyder att vi kan starta anropa metoden från andra klasser
    // Men eftersom vi har använt void så returnerar metoden ingeting 
    // när vi anropar den. Dem toma parateser saknar indata så 
    // koden kommer bara att köras, när denna anropas.
    public void ScheduleCourse()
    {
        // Här går koden igenom listan kurser som jag har valt att kalla c
        foreach (Course c in courses)
        {
            // Här komme nu att skrivas ut varje kurs.
           Console.WriteLine(c.Name);
        }
    }
    // Metoden ör nu nårbar för andra klasser eller fullt synlig.
    // Eftersom ToSring har en fast metod eller standars så säger vi till 
    // den att strunta i den och gör som jag vill istället.
    // Eftersom vi inte har void så vill vi returnera ett värde.
    public override string ToString()
    {    
        // Här returneras den värde vi villa ha i detta fall
        // Den studerandes namn.
        return Name;
    }

}



