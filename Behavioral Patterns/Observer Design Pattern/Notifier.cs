using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern
{
    public abstract class Notifier
    {
        protected ListNotifier _listNotifier;

        public abstract void Notify(ListNotifier listNotifier);
    }
}
