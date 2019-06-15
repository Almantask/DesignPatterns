using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core.TV
{
    public class VolumeUpCommand : ITvCommand
    {
        public void Execute(Television tv)
        {
            tv.Volume += 1;
            Console.WriteLine($"Current volume {tv.Volume}");
        }
    }
}
