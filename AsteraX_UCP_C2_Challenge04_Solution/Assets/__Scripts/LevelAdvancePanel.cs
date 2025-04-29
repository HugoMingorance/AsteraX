using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelAdvancePanel : MonoBehaviour
{
    public GameObject playerShip;
    public int level;
    public TextMeshProUGUI levelText;
    private GameObject[] bullets;
    public Button nextButton;
    public AsteraX asteraX;
    
    private void Awake()
    {
        level = AsteraX.level;
        Debug.Log("level is asterax level " + level);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("STARTEDLEVELADVANCEPANEL");
        
        nextButton.onClick.AddListener(OnNextButonClick);
        
        asteraX = GameObject.Find("Main Camera").GetComponent<AsteraX>();
        
        nextButton.interactable = false;
        Invoke("makeButtonInteractable", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateLevelAdvancePanel()
    {
        if (playerShip != null && !playerShip.activeInHierarchy)
        {
            //Desactivem player
            playerShip.SetActive(false);
        }
        
        //Desactivem bullets
        bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(false);
        }
        
        level++;
        Debug.Log("level is incremented " + level);
        levelText.text = "Level " + level;
    }

    public void OnNextButonClick()
    {
        level = asteraX.IncrementLevel();
        Debug.Log("LEVEL RETURN: " + level);
        Invoke("advanceLevel", 0.5f);
    }

    public void advanceLevel()
    {
        Debug.Log("Invoked function advanceLevel");
        AsteraX.GAME_STATE = AsteraX.eGameState.level;
        playerShip.SetActive(true);
        gameObject.SetActive(false);
        nextButton.interactable = false;
    }

    public void makeButtonInteractable()
    {
        nextButton.interactable = true;
    }
    
    
}
