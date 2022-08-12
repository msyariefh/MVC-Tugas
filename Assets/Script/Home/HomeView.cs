using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Boot;
using UnityEngine.Events;

namespace HiDE.MVCTry.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] Button _playButton;

        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}

