using System;


namespace Assets.MyScripts
{
    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
