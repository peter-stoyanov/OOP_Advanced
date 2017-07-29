using System;

namespace Problem7_Equality_Logic.Models
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);
            
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            Person otherPerson = null;

            if (obj is Person)
            {
                otherPerson = (Person)obj;
            }

            if (otherPerson == null) { return false; }

            if (this.Name == otherPerson.Name && this.Age == otherPerson.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (this.Name + this.Age.ToString()).GetHashCode();
        }
    }
}