using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenPanel : ActiveOnlyDuringSomeGameStates
{
    public Button startButton;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnStartButtonClicked()
    {
        AsteraX.GAME_STATE = AsteraX.eGameState.level;
    }
    
}
