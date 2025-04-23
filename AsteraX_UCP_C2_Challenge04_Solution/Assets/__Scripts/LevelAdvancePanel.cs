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
    
    private void Awake()
    {
        Debug.Log("LevelAdvancePanel Awake");

        AsteraX.level++;
        level = AsteraX.level;
        levelText.text = "LEVEL " + level.ToString();
        
        //Desactivem player
        playerShip.SetActive(false);
        
        //Desactivem bullets
        bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(false);
        }
        
        nextButton.onClick.AddListener(OnNextButonClick);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextButonClick()
    {
        AsteraX.GAME_STATE = AsteraX.eGameState.level;
        playerShip.SetActive(true);
        gameObject.SetActive(false);
    }
    
    
}
