using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core.TV
{
    public class TurnOnTvCommand : ITvCommand
    {
        public void Execute(Television tv)
        {
            tv.IsOn = true;
            Console.WriteLine("Tv- on!");
        }
    }
}
