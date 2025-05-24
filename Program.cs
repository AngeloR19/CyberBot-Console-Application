using PROG6221Part1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG6221Part1
{
    internal class Program
    {
        static void Main()
        {
             
            MainWorker mainWorker = new MainWorker();
            mainWorker.Run(); // Start the main worker process
        }
    }
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////