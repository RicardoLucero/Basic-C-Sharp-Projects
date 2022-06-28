using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello World!";
            string secondString = "My name is Ricardo.";
            string thirdString = "Nice to meet you!";
            string favActivity = "Skateboarding";

            Console.WriteLine(firstString + " " + secondString + " " + thirdString);
            favActivity = favActivity.ToUpper();

            Console.WriteLine(favActivity);

            StringBuilder sb = new StringBuilder();
            sb.Append("Despite the fact that piranhas are relatively harmless, \nmany people continue to believe the pervasive myth that piranhas \nare dangerous to humans.");
            sb.Append("This impression of piranhas is \nexacerbated by their mischaracterization in popular media.\n");
            sb.Append("For example, the promotional poster \nfor the 1978 horror film Piranha features an oversized piranha \npoised to bite the leg of an unsuspecting woman.\n");
            sb.Append("Such a terrifying representation easily \ncaptures the imagination and promotes unnecessary fear.\n");
            sb.Append("While the trope of the man-eating piranhas \nlends excitement to the adventure stories, \nit bears little resemblance to the real-life piranha.\n");
            sb.Append("By paying more attention to fact than fiction, \nhumans may finally be able to let go of this inaccurate belief.");

            Console.WriteLine(sb);
        }
    }
}
