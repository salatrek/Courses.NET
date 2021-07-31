using System;

namespace ThirdLesson_Homework_Equals_GetHashCode_
{
    public class Person
    { 
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Birthplace { get; set; }
        public int PassportID { get; set; }

        public Person(string fullName, DateTime dateOfBirth, string birthplace, int passportID)
        {
            FullName = string.IsNullOrWhiteSpace(fullName) ? throw new ArgumentNullException(nameof(fullName)) : fullName;

            DateOfBirth = dateOfBirth < DateTime.MinValue ? throw new ArgumentNullException(nameof(dateOfBirth)) : dateOfBirth;

            Birthplace = string.IsNullOrWhiteSpace(birthplace) ? throw new ArgumentNullException(nameof(birthplace)) : birthplace;

            PassportID = passportID <= 0 ? throw new ArgumentNullException(nameof(passportID)) : passportID;

        }

        public override bool Equals(object obj)
        {
            if (obj == null && !(obj is Person))
            { 
                return false; 
            }

            var person = (Person)obj;

            return person.PassportID == PassportID;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(FullName, PassportID).GetHashCode();
        }
    }
}
