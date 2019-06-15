using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core.TV
{
    public class TurnOffTvCommand : ITvCommand
    {
        public void Execute(Television tv)
        {
            tv.IsOn = false;
            Console.WriteLine("Tv- OFF!");
        }
    }
}
