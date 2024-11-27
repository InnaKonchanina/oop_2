using pract_2;
using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть кількість уроків: ");
int n = int.Parse(Console.ReadLine());
Teacher teacher = new Teacher("Олександр");
Student student = new Student("Андрій");
for (int i = 1; i <= n; i++)
{
    Bell bell = new Bell(i);
    bell.Event1 += teacher.OnLessonStart;
    bell.Event1 += student.OnLessonStart;
    bell.Event2 += teacher.OnLessonEnd;
    bell.Event2 += student.OnLessonEnd;
    bell.Ring();
    Console.WriteLine();
    Console.ReadKey();
}

namespace pract_2
{
    class Bell
    {
        public int LessonNumber { get; }
        public event Action Event1; 
        public event Action Event2; 

        public Bell(int lessonNumber)
        {
            LessonNumber = lessonNumber;
        }
        public void Ring()
        {
            Console.WriteLine($"Звонок на {LessonNumber} урок.");
            Event1?.Invoke(); // Виклик події "Звонок на урок"

            Console.WriteLine($"Звонок з {LessonNumber} уроку.");
            Event2?.Invoke(); // Виклик події "Звонок з уроку"
        }
    }

    class Teacher
    {
        public string Name { get; }
        public Teacher(string name)
        {
            Name = name;
        }
        public void OnLessonStart()
        {
            Console.WriteLine($"Учитель {Name} йде на урок.");
        }
        public void OnLessonEnd()
        {
            Console.WriteLine($"Учитель {Name} йде в учительську.");
        }
    }

    class Student
    {
        public string Name { get; }
        public Student(string name)
        {
            Name = name;
        }
        public void OnLessonStart()
        {
            Console.WriteLine($"Учень {Name} йде на урок.");
        }
        public void OnLessonEnd()
        {
            Console.WriteLine($"Учень {Name} йде на перерву.");
        }
    }
}
