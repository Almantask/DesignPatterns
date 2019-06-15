using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core.TV
{
    public class Television
    {
        public int Volume { get; set; }
        public int Channel { get; set; }
        public bool IsOn { get; set; }

        private IRemoteController _runner;

        public Television(IRemoteController runner)
        {
            _runner = runner;
            _runner.SignalSent += OnSignalReceived;
        }

        private void OnSignalReceived(object sender, ITvCommand cmd)
        {
            cmd.Execute(this);
        }

    }
}
