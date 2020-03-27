using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern
{
    public class Notifier_Facebook : Notifier
    {
        public override void Notify(ListNotifier listNotifier)
        {
            Console.WriteLine("Facebook notify!");
        }

        public Notifier_Facebook()
        {

        }

        public Notifier_Facebook(ListNotifier listNotifier)
        {
            _listNotifier = listNotifier;
            _listNotifier.AddNotifier(this);
        }
    }
}
