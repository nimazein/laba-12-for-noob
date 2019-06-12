using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_for_noob
{
    class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }

        public Student()
        {

        }
        public Student(int age, string name, int course, string group)
            :base(age, name)
        {
            Course = course;
            Group = group;           
        }

        public Person BasePerson
        {
            get
            {
                return new Person(Age, Name);
            }
            
        }
        public override string ToString()
        {
            return $"Возраст: {Age}, Имя: {Name}, Курс: {Course}, Группa: {Group}";
        }

    }
}
