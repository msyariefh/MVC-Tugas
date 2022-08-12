using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Boot;

namespace HiDE.MVCTry.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
    }
}

