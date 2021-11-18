using Beziere.Enums;
using System.Collections.Generic;

namespace Beziere
{
    public static class Dictionaries
    {
        public readonly static Dictionary<ActionEnum, string> ActionTypesDictionary = new()
        {
            { ActionEnum.NoAction, "Brak" },
            { ActionEnum.DrawPoints, "Rysuj punkty" },
            { ActionEnum.MoveMouse, "Przesuwanie myszą" },
            { ActionEnum.MoveKeyboard, "Przesuwanie \npolem tekstowym" },           
        };
    }
}
