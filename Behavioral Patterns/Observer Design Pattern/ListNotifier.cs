using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern
{
    public class ListNotifier
    {
        private readonly List<Notifier> _notifiers = new List<Notifier>();

        public void AddNotifier(Notifier notifier)
        {
            _notifiers.Add(notifier);
        }

        public void RemoveNotifier(Notifier notifier)
        {
            _notifiers.Remove(notifier);
        }

        public void Notify(ListNotifier list)
        {
            _notifiers.ForEach((notifier) => notifier.Notify(list));
        }
    }
}
