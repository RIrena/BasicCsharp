using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework No.2 from Class 04");

            string Message = "The&nbsp;&nbsp;&nbsp; best &nbsp;Lorem&nbsp; " +
                "Ipsum&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generator in all the&nbsp; sea!&nbsp;&nbsp; " +
                "Heave this &nbsp; scurvy copyfiller fer yar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " +
                "next&nbsp;&nbsp; adventure&nbsp; and cajol yar clients&nbsp;&nbsp; into walking  the plank with  ev'ry layout!&nbsp;&nbsp;&nbsp; " +
                "Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own the high seas,&nbsp;&nbsp;&nbsp; argh!";

            // Mi dava greska deka nemoze da convertiram od string vo int - ama neznam kade mi e greskata

            string removeString = Message.Remove("&nbsp;");
            Console.WriteLine(removeString);

            Console.ReadLine();
        }
    }
}
