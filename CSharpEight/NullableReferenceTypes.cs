

namespace CSharpEight
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        
        public Person(string first, string last, string middle) =>
          (FirstName, LastName, MiddleName) = (first, last, middle);
        
        public string FullName =>
          $"{FirstName} {MiddleName[0]} {LastName}";
    }

    public class NullableReferenceTypes
    {
        public static void Demo()
        {

        }
    }
}
