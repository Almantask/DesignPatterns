using System;

namespace DesignPatternsLesson1.Core.TV
{
    public class VolumeDownCommand : ITvCommand
    {
        public void Execute(Television tv)
        {
            tv.Volume-= 1;
            Console.WriteLine($"Current volume {tv.Volume}");
        }
    }
}
