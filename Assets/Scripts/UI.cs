using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]

public class UI {

    [Serializable]

    public class HUD
    {
        [Header("Text")]
        public Text txtCoinCount;

        public Text textLifeCount;

        public Text txtTimer;


        [Header("Other")]
        public GameObject HudPanel;
    }
    

    [Serializable]

    public class GameOver
    {
        [Header("Text")]
        public Text txtCoinCount;
        
        public Text txtTimer;


        [Header("Other")]
        public GameObject GameOverPanel;
    }

    [Serializable]

    public class LevelComplete
    {
        [Header("Text")]
        public Text txtCoinCount;

        public Text txtTimer;


        [Header("Other")]
        public GameObject LevelCompletePanel;
    }

    public LevelComplete levelComplete;

    public GameOver gameOver;

    public HUD hud;
}
