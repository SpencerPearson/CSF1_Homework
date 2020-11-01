using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main()
        {
            Console.WriteLine("A Halloween Mad Lib!");
            Console.WriteLine("For this Mad Lib you will be asked to input several words in order to create a silly story. For each prompt, enter any word you choose of the indicated word type. Verbs should be in standard present tense, e.g., \"jump, laugh, shout,\" unless otherwise specified. Adverbs modify verbs, e.g., \"quickly, happily.\" Adjectives are descriptors of nouns, such as \"purple, furry, enormous.\"");

            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();
            Console.Write("Enter a famous movie star: ");
            string costume1 = Console.ReadLine();
            Console.Write("Enter a name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter a famous musician: ");
            string costume2 = Console.ReadLine();
            Console.Write("Enter an adverb: ");
            string adverb1 = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter a verb (past tense): ");
            string verb1 = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Enter a body part (plural): ");
            string noun3 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb2 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjective2 = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun4 = Console.ReadLine();
            Console.Write("Enter a name: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter a famous political leader: ");
            string costume3 = Console.ReadLine();
            Console.Write("Enter a number: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjective3 = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            string noun5 = Console.ReadLine();
            Console.Write("Enter a verb (past tense): ");
            string verb3 = Console.ReadLine();
            Console.Write("Enter a verb (past tense): ");
            string verb4 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb5 = Console.ReadLine();

            Console.WriteLine($"This year Halloween was so {adjective1}! I went as {costume1} and my best friend {name1} went as {costume2}. Everything was going {adverb1} until a {noun1} {verb1} our {noun2}! We could not believe our {noun3}. {name1} said, \"We need to {verb2} right now!\" Just then, the {noun1} pulled a {adjective2} {noun4} out of nowhere. Luckily, that was the moment when our friend {name2} showed up dressed as {costume3} with {number1} {adjective3} {noun5}. The {noun1} {verb3} away and we all {verb4} together. That's the last time {costume1} and {costume2} will ever {verb5} around at night without {costume3}!");
        }
    }
}
