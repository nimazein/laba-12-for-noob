using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_for_noob
{
    class Collection
    {
        public Stack<Person> BaseObj { get; set; }
        Stack<string> ToStringValues { get; set; }
        SortedDictionary<Person, Student> PersonStudent { get; set; }
        SortedDictionary<string, Student> StringStudent { get; set; }

        public Collection()
        {
            
        }
        public Collection(int size)
        {
            BaseObj = new Stack<Person>(size);
            ToStringValues = new Stack<string>(size);
            PersonStudent = new SortedDictionary<Person, Student>();
            StringStudent = new SortedDictionary<string, Student>();
        }
        public void Add(Student student)
        {
            BaseObj.Push(student.BasePerson);
            ToStringValues.Push(student.ToString());

            PersonStudent.Add(student.BasePerson, student);
            StringStudent.Add(student.ToString(), student);

        }
        public void Generate()
        {
            string [] names {
                "Иван",

            }
        }

    }
}
