﻿namespace DesignPatterns.Mediator
{
    public class UiControl
    {
        protected DialogBox _owner;

        public UiControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
