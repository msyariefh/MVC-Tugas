using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace HiDE.MVCTry.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        private void SaveData()
        {
            Debug.Log($"Total coin saved {_model.Coin}");
            PlayerPrefs.SetInt("Coin", _model.Coin);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            int coin = PlayerPrefs.GetInt("Coin");
            _model.SetCoinData(coin);
            SaveData();
        }
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnUpdateCoin(int coin)
        {
            _model.SetCoinData(coin);
        }
    }
}

