using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSorting.ViewModel
{
    public class DataGridSortingViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public DataGridSortingViewModel()
        {
            People = new ObservableCollection<Person>
                    {
                        new Person { Name = "Arun", Age = 30, Email = "arun@example.com" },
                        new Person { Name = "John", Age = 25, Email = "john@example.com" },
                        new Person { Name = "Jane", Age = 28, Email = "jane@example.com" }
                    };
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }

    }
}
