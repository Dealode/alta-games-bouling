using System;

namespace CodeBase.Gameplay.UserInput
{
    public interface ITouchAction
    {
        event Action StartHold;
        event Action EndHold;
    }
}