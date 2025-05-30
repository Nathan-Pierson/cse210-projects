using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Learning Machine!");
        Console.WriteLine("Here are some Scriptures you can choose to start memorizing!");
        Console.WriteLine();

        //This is a list of all the scriptures they can choose from
        List<string> verses = new List<string>
        {

            @"Mosiah 2:17 ~
            And behold, I tell you these things that ye may learn wisdom; that ye may learn 
            that when ye are in the service of your fellow beings ye are only in the service 
            of your God.",

            @"Moroni 10:4-5 ~
            4 And when ye shall receive these things, I would exhort you that ye would ask God, 
            the Eternal Father, in the name of Christ, if these things are not true; and if ye 
            shall ask with a sincere heart, with real intent, having faith in Christ, he will 
            manifest the truth of it unto you, by the power of the Holy Ghost.

            5 And by the power of the Holy Ghost ye may know the truth of all things.",

            @"3-Nephi 12:48 ~
            Therefore I would that ye should be perfect even as I, or your Father who is in
            heaven is perfect.",

        };

        //This displays all the scriptures, I could have made this a loop, but there 
        //were very few verses.
        Console.WriteLine($"1. {verses[0]}");
        Console.WriteLine();
        Console.WriteLine($"2. {verses[1]}");
        Console.WriteLine();
        Console.WriteLine($"3. {verses[2]}");

        //This reads what scripture they want to do.
        Console.WriteLine("What Scripture do you want to work on?");
        Console.Write(">>> ");
        string verse = Console.ReadLine();

        //This sets there verse into the reference and scripture private attributes 
        if (verse == "1")
        {
            //Breaks the verse into a reference variable and a text variable
            string[] array = verses[0].Split("~");
            List<string> script = array.ToList();
            string reference = script[0];
            string text = script[1];

            //This calls the setting methods of each class
            Reference r = new Reference();
            r.setReference(reference);

            Scripture s = new Scripture(text);

            //Just a test // Just a test // just a test// just a test
            Console.Clear();
            string refer = r.getReference();
            Console.WriteLine(refer);
            List<string> tex = s.getText();
            foreach (string t in tex)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //Verse Moroni 10:4-5
        else if (verse == "2")
        {
            //Breaks the verse into a reference variable and a text variable
            string[] array = verses[1].Split("~");
            List<string> script = array.ToList();
            string reference = script[0];
            string text = script[1];

            //This calls the setting methods for the reference attributes
            Reference r = new Reference();
            r.setReference(reference);

            //This calls the methods to set the Scripture attributes
            Scripture s = new Scripture(text);


            //Just a test // Just a test // just a test// just a test
            string refer = r.getReference();
            Console.WriteLine(refer);
            List<string> tex = s.getText();
            foreach (string t in tex)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //Verse 3 Nephi
        else if (verse == "3")
        {
            //Breaks the verse into a reference variable and a text variable
            string[] array = verses[2].Split("~");
            List<string> script = array.ToList();
            string reference = script[0];
            string text = script[1];

            //This calls the setting methods for the reference attributes
            Reference r = new Reference();
            r.setReference(reference);

            //This calls the methods to set the Scripture attributes
            Scripture s = new Scripture(text);


            //Just a test // Just a test // just a test// just a test
            Console.Clear();
            string refer = r.getReference();
            Console.WriteLine(refer);
            List<string> tex = s.getText();
            foreach (string t in tex)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //If the user chooses a choice that isn't available
        else
        {
            Console.WriteLine("Please Choose a given numbered option.");
        }

    }
}