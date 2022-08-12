using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using HiDE.MVCTry.Boot;
using HiDE.MVCTry.ClickGame;

namespace HiDE.MVCTry.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public ClickGameView ClickGameView;
    }
}

