using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Message();
            string name = HelloName("Scott");
            

            string firstName = string.Empty;
            string lastName = string.Empty;
            string fullName = "Scott Kuhl";
            HelloPartName(fullName, out firstName, out lastName);

          

            Print();
            Console.ReadLine();
        }

        //below is the simplest method we can use. if we want to use it above we can type in Hello(); make sure when writing methods use static
        //when you create methods it allows you to group your logic together in smaller pieces
        //parts of method 
        //public - its accessibility (if public - anyone can call it, private means it can be called inside the same class, internal means your program can call it
        //static - can you call the code whenever or do you need to make classes?
        //void is a return type if you use anything other than void then you will be snending something back. 

            //part 1 simple form, no input, no ouput
        public static void Print()
        {
            Console.WriteLine("Hello!");
        }
        //return types
        //part 2 output
        private static string Message()
        {
            return "Hello Message!";
        }

        //parameters
        //we want to return scott but scott needs a variable
        //part 3 - input and output
        private static string HelloName(string name)
        {
            return "Hello " + name;
        }
        //XML COMMENT:

            /// <summary>
            /// say hello to the person.
            /// </summary>
            /// <param name="firstName">first name of the person.</param>
            /// <param name="lastName">last name of the person. </param>
            /// <returns>Hello full name. </returns>
        //part 4 multiple input
        private static string HelloFullName(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }

        //part 5 - multipe output (not usually a good idea, there are some times when this is okay though)

        private static void HelloPartName(string fullName, out string firstName, out string lastName)
        {
            firstName = fullName.Split(' ')[0];
            lastName = fullName.Split(' ')[1];
        }

        //what is overloading? using the same name more than once using different perameters
    }
}
