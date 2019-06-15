using DesignPatternsLesson1.Core.TV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Presentation
{
    public class TvSimulation
    {
        public void Run()
        {
            var tvRemote = new TvRemoteController();
            var tv = new Television(tvRemote);

            var cmds = new List<ITvCommand>
            {
                new TurnOnTvCommand(),
                new VolumeUpCommand(),
                new VolumeDownCommand(),
                new SwitchChannelCommand(3),
                new SwitchChannelCommand(2),
                new SwitchChannelCommand(9),
                new TurnOffTvCommand()
            };
            
            foreach(var cmd in cmds)
            {
                tvRemote.Signal(cmd);
            }

            Console.ReadLine();
        }


    }
}
