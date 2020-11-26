using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLoger
{
    class Begin
    {
        public void Run()
        {
            Random rnd = new Random();

            Actions action = new Actions();

            Logger loger = Logger.CreateUnique();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
                try
                {
                    switch (rnd.Next(0,3))
                    {
                        case 0:
                            action.InfoMessage();
                            break;
                        case 1:
                            action.WarningMessage();
                            break;
                        case 2:
                            action.ExeptionMessage();
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(loger.Message(exception, "Error"));
                }
            }

            loger.SaveLogetList();

        }
    }
}
