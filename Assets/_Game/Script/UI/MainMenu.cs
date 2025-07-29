using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenu : UICanvas
{
    [SerializeField] private TextMeshProUGUI leveltxt;

    private void Update()
    {
        leveltxt.text = LevelManager.Instance.CurrentLevel.id;
    }

    public void PlayButton()
    {
        LevelManager.Instance.OnStartGame();

        UIManager.Instance.OpenUI<Gameplay>();
        Close();

    }
}
