using System.ComponentModel;

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
            Console.WriteLine("Kursen är tyvärr full. ")
        }



      
      
      
      
      
        
    }









}