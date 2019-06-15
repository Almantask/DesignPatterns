using System;

namespace DesignPatternsLesson1.Core.TV
{
    public interface IRemoteController
    {
        void Signal(ITvCommand cmd);
        event EventHandler<ITvCommand> SignalSent;
    }
}