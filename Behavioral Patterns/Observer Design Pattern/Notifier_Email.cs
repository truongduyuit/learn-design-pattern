using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern
{
    public class Notifier_Email : Notifier
    {
        public override void Notify(ListNotifier listNotifier)
        {
            Console.WriteLine("Email notify !");
        }

        public Notifier_Email()
        {

        }

        public Notifier_Email(ListNotifier listNotifier)
        {
            _listNotifier = listNotifier;
            _listNotifier.AddNotifier(this);
        }
    }
}
