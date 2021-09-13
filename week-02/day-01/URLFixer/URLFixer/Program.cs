using System;

namespace URLFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            //url.Replace("https//www.reddit.com/r/nevertellmethebots", "https://www.reddit.com/r/nevertellmetheodds/comments/9zot8e/never_tell_me_the_odds/");
            url = url.Trim();
            url = "https://www.reddit.com/r/nevertellmetheodds/comments/9zot8e/never_tell_me_the_odds/";

            Console.WriteLine(url);
        }
    }
}
