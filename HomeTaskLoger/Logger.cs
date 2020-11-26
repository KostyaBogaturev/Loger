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

        public string Message(string warning, string message)
        {
            string warningReason = $"{message} : warning {warning}";
            list.Add(warningReason);
            return warningReason;
        }

        public void SaveLogetList(string fileName)
        {
            File.AppendAllLines(fileName, list);
        }


    }
}
