using Calc.Domain.Model.States;

namespace Calc.Application.States
{
    public class StateData
    {
        public string? Main { get; private set; }
        public string? Sub { get; private set; }
        public string? Operator { get; private set; }

        public StateData(State state)
        {
            Operator = state.Operator?.ToString();
            Main = state.Main;
            Sub = state.Sub;
        }
    }
}