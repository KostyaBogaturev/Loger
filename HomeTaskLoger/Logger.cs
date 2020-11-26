using System;
using System.Collections.Generic;
using System.IO;

namespace HomeTaskLoger
{
    class Logger
    {
        private static Logger unique;

        private List<string> list=new List<string>();

        private Logger()
        {

        }

        public static Logger CreateUnique()
        {
            if (unique == null)
                unique = new Logger();
            return unique;
        }

        public string Message(Exception exception ,string message)
        {
            string errorReason = $"{message} : action failby the reason {exception.StackTrace}";
            list.Add(errorReason);
            return errorReason;
        }

        public string Message(string info, string message)
        {
            string information = $"{message} : warning {info}";
            list.Add(information);
            return information;
        }

        public void SaveLogetList(string fileName)
        {
            File.AppendAllLines(fileName, list);
        }


    }
}
