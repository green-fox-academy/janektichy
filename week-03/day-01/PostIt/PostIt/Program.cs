using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt post = new PostIt("Idea 1", ConsoleColor.Blue, ConsoleColor.Yellow);
            post.MakeParagraph();

            PostIt post2 = new PostIt("Awesome", ConsoleColor.Black, ConsoleColor.Red);
            post2.MakeParagraph();

            PostIt post3 = new PostIt("Superb", ConsoleColor.Green, ConsoleColor.Yellow);
            post3.MakeParagraph();
        }
    }
    
}
