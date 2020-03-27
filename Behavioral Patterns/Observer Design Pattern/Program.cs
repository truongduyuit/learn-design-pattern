using System;

namespace Observer_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video();

            var emailNotifier = new Notifier_Email(video);
            var facebookNotifier = new Notifier_Facebook(video);

            video.SetTitle("Video's title change");

            Console.ReadKey();
        }
    }
}
