using System;

namespace NullableReferenceTypes
{
    /// <summary>
    /// Feature is nullable references types, giving you more warnings where your behaviour isnt null safe
    //  To enable this edit your project file and set <Nullable>enable</Nullable>
    //  This will show you uninitialised properties which thus considers reference types as no nullable
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var miguel = new Person("Miguel", "de Icaza");
            var length = GetMiddleNameLength(miguel);
            Console.WriteLine(length);
        }

        //Original Code
        //private static object GetMiddleNameLength(Person person)
        //{
        //    //Exception is thrown and tells us that middle name is null when referencing it
        //    var middle = person.MiddleName;
        //    return middle.Length;
        //}

        //private static object GetMiddleNameLength(Person person)
        //{
        //    var middle = person.MiddleName;
        //    //if (middle == null) return 0;

        //    //Patterns in C# 7 allow you to use is in place of the equality operator
        //    if (middle is null) return 0;
        //    //Essentials a flow analysis, will never be null at this point in time
        //    return middle.Length;
        //}

        ////Inline temporary variable   
        //private static object GetMiddleNameLength(Person person)
        //{
        //    if (person.MiddleName is null) return 0;
        //    return person.MiddleName.Length;
        //}

        ////Inline temporary variable   
        //private static int GetMiddleNameLength(Person? person)
        //{
        //    //Checks for null and only does deferences if it is null
        //    // Use null coalesce to turn any nulls into 0;
        //    return person?.MiddleName?.Length ?? 0;
        //}

        ////If you want to check if a parameter is not null instead of is null you can use pattern matching
        //Property Pattern
        private static object GetMiddleNameLength(Person? person)
        {
            return person?.MiddleName is { Length: var length } ? length : 0;
        }

        // ! - Null ignoring operator  
        //return !middle.Length;
    }
}