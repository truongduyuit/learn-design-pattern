using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern
{
    public class Video : ListNotifier
    {
        private string _title;
        private string _description;
        private string _fileName;

        public string GetTitle() { return _title; }
        public void SetTitle(string title)
        { 
            _title = title;
            VideoDataChang();
        }

        public string GetDescription() { return _description; }
        public void SetDescription(string description)
        {
            _description = description;
            VideoDataChang();
        }

        public string GetFileName() { return _fileName; }
        public void SetFileName(string fileName)
        {
            _fileName = fileName;
            VideoDataChang();
        }

        private void VideoDataChang()
        {
            Notify(this);
        }
    }
}
