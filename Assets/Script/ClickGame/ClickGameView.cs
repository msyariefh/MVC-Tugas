using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Boot;
using TMPro;
using UnityEngine.Events;

namespace HiDE.MVCTry.ClickGame
{
    public class ClickGameView : ObjectView<IClickGameModel>
    {
        [SerializeField]
        private TMP_Text _coinText;
        [SerializeField]
        private Button _earnCoinButton;
        [SerializeField]
        private Button _spendCoinButtton;
        [SerializeField]
        private Button _backButton;

        public void SetCallbacks(UnityAction onClickEarnCoin, 
            UnityAction onClickSpendCoin, UnityAction onClickBack)
        {
            _earnCoinButton.onClick.RemoveAllListeners();
            _spendCoinButtton.onClick.RemoveAllListeners();
            _backButton.onClick.RemoveAllListeners();
            _earnCoinButton.onClick.AddListener(onClickEarnCoin);
            _spendCoinButtton.onClick.AddListener(onClickSpendCoin);
            _backButton.onClick.AddListener(onClickBack);
        }

        protected override void InitRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
        }

        protected override void UpdateRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
        }
    }
}

