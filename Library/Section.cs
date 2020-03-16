using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Section
    {
        public string sectionName { get; set; }
        List<Shelve> shelves = new List<Shelve>();

        public Section(string SectionName)
        {
            this.sectionName = SectionName;
        }

        public void AddShelve(string shelveName)
        {
            Shelve shelve = new Shelve(shelveName);
            shelves.Add(shelve);
        }

        public void RemoveShelve(string shelveName)
        {
            foreach(Shelve s in shelves)
            {
                if (s.shelveName == shelveName)
                {
                    shelves.Remove(s);
                    break;
                }
            }
        }

        public void ShowShelve()
        {
            foreach (Shelve s in shelves)
            {
                Console.WriteLine(s.shelveName);
            }
        }

    }
}
