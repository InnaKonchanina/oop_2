using System.Text;

namespace Lab_4
{
    internal class Program
    {
        struct Discipline
        {
            public string SubjectName;
            public int Hours;
            public string Department;

            public Discipline(string subjectName, int hours, string department)
            {
                SubjectName = subjectName;
                Hours = hours;
                Department = department;
            }

            public string GetInfo()
            {
                return $"Предмет: {SubjectName}, Часы: {Hours}, Кафедра: {Department}";
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<Discipline> disciplines = new List<Discipline>();

            // Ввод количества предметов
            Console.Write("Введите количество предметов: ");
            int n = int.Parse(Console.ReadLine());

            // Ввод данных о предметах
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВведите данные для предмета {i + 1}:");

                Console.Write("Название предмета: ");
                string subjectName = Console.ReadLine();

                Console.Write("Количество часов: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Название кафедры: ");
                string department = Console.ReadLine();

                disciplines.Add(new Discipline(subjectName, hours, department));
            }

            // Вывод списка предметов на экран
            Console.WriteLine("\nСписок предметов:");
            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline.GetInfo());
            }

            // Ввод названия кафедры
            Console.Write("\nВведите название кафедры: ");
            string inputDepartment = Console.ReadLine();

            // Вывод списка предметов по кафедре
            var subjectsByDepartment = disciplines.Where(d => d.Department == inputDepartment).ToList();

            Console.WriteLine($"\nПредметы на кафедре {inputDepartment}:");
            foreach (var discipline in subjectsByDepartment)
            {
                Console.WriteLine(discipline.GetInfo());
            }

            // Подсчет общего количества часов по кафедре
            int totalHours = subjectsByDepartment.Sum(d => d.Hours);
            Console.WriteLine($"\nОбщее количество часов на кафедре {inputDepartment}: {totalHours}");
        }
    }
}
