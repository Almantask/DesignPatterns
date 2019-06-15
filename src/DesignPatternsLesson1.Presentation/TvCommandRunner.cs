using DesignPatternsLesson1.Core.TV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Presentation
{
    class TvRemoteController : IRemoteController
    {
        public event EventHandler<ITvCommand> SignalSent;

        public void Signal(ITvCommand cmd)
        {
            Console.WriteLine($"Sending signal- {cmd}");
            SignalSent?.Invoke(this, cmd);
            Console.WriteLine($"Signal Complete- {cmd}");
        }
    }
}
