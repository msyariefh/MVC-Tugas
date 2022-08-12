using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Soundfx;
using HiDE.MVCTry.SaveData;
using HiDE.MVCTry.Message;

namespace HiDE.MVCTry.Gameplay
{
    public class GamePlayConnector : BaseConnector
    {
        private SoundfxController _soundfx;
        private SaveDataController _saveData;
        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }
    }
}

