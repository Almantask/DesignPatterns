using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core.TV
{
    public class SwitchChannelCommand:ITvCommand
    {
        private readonly int _channel;

        public SwitchChannelCommand(int channel)
        {
            _channel = channel;
        }

        public void Execute(Television tv)
        {
            tv.Channel = _channel;
            Console.WriteLine($"Current channel {tv.Channel}");
        }
    }
}
