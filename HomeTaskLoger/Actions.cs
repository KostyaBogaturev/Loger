using System;

namespace HomeTaskLoger
{
    class Actions
    {
        public void InfoMessage()
        {
            Logger loger = Logger.CreateUnique();
            Console.WriteLine(loger.Message("Info","Sending a message from method: InfoMessage"));
        }

        public void WarningMessage()
        {
            Logger loger = Logger.CreateUnique();
            Console.WriteLine(loger.Message("Warning", "Sending a warning from method: WarningMessage"));
        }

        public void ExeptionMessage()
        {
            throw new Exception("Why we have to write \" I broke a toilet&)\"");
        }
    }
}
