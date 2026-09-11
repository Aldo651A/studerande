using System.ComponentModel;
// Detta kallas för primary constructer och här skapar vi Course.
// För att skicka in namne gör vi detta me string och antalet platser med int.
// eftersom int kontrolerar antal.
class Course(string name, int maxSeats)
{
    public string Name = name;
    public int MaxSeats = maxSeats;
    public List<Student> students = [];

    public bool Enroll(Student studentToEnroll)
    {
        if (students.Count < MaxSeats)
        {
            students.Add(studentToEnroll);
            Console.WriteLine("Studenten är nu registrerad ");
            return true;
        }
        else
        {
            Console.WriteLine("Tyvärr så finns det inga lediga platser. ");
            return false;
        }  
    }
    public bool UnEnroll(Student studentToLeave)
    {
        if (students.Contains(studentToLeave))
        {
            students.Remove(studentToLeave);
            Console.WriteLine("Tyvärr så slutade en student. En plats är ledig. ");
            return true;
        }
        else
        {
            Console.WriteLine("Det finns inga lediga platser. ");
            return false;
        }
    }
    public void Rollcall()
    {
        


        
    }










}