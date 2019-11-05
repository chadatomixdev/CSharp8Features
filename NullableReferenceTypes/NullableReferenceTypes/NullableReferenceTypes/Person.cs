namespace NullableReferenceTypes
{
    public class Person
    {
        public string FirstName { get; set; }

        //To Make nullable reference type add question mark
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}