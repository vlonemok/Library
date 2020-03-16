using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Section> sections = new List<Section>();
            Console.Write("Введите название секции: ");
            Section section = new Section(Console.ReadLine());
            sections.Add(section);
            while (true)
            {
                Console.WriteLine("1. Добавить полку\n2. Просмотреть полки\n3. Удалить полку\n4. Добавить книгу\n5. Просмотреть книги\n6. Удалить книгу");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Write("Введите имя добавляемой полки: ");
                        section.AddShelve(Console.ReadLine());
                        break;
                    case 2:
                        section.ShowShelve();
                        break;
                    case 3:
                        Console.Write("Введите имя полки, которую хотите удалить: ");
                        section.RemoveShelve(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Введите название добавляемой книги: ");
                        
                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Write("Введите имя книги, которую хотите удалить: ");

                        break;
                }
            }
        }
    }
}
