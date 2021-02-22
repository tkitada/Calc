using System;

namespace Calc.Application.States
{
    public class NotifyStateChangedEventArgs : EventArgs
    {
        public StateData State { get; set; }

        public NotifyStateChangedEventArgs(StateData state) => State = state;
    }
}