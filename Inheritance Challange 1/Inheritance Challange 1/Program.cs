using System;

namespace Inheritance_Challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta",
                "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());

            VideoPost myVid = new VideoPost("OMG this is so funny", "https://www.youtube.com", 18.36f, "Harry Smith");
            Console.WriteLine(myVid.ToString());

            myVid.Play();
            myVid.Stop();

        }
    }
}
