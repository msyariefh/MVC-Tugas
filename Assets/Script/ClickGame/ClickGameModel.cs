using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Boot;

namespace HiDE.MVCTry.ClickGame
{
    public class ClickGameModel : BaseModel, IClickGameModel
    {
        public int Coin { get; private set; }

        public void SetCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }

        public void AddCoin()
        {
            Coin++;
            SetDataAsDirty();
        }

        public void SubstractCoin()
        {
            Coin--;
            SetDataAsDirty();
        }

        public void SetCoinData(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }
    }
}

