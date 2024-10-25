namespace StudentenListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe: Erstelle ein Programm mit einer Liste von Studenten
            // Verwende für die Studenten eine Klasse
            // Jeder Student hat einen NC
            // Berechne dann den durchschnittlichen NC aller Studenten mit einer Schleife

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Jannick", 2.3f));
            students.Add(new Student(2, "Peter", 1.8f));
            students.Add(new Student(3, "Maria", 2.1f));

            float totalGradePoints = 0;

            foreach (Student student in students) 
            {
                totalGradePoints += student.GradePointAverage;
            }

            float nc = totalGradePoints / students.Count;

            Console.WriteLine(nc);
            Console.ReadKey();

        }
    }
}
