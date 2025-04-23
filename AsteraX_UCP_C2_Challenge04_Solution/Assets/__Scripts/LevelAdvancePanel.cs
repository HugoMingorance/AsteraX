using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdvancePanel : MonoBehaviour
{
    public GameObject playerShip;
    
    private void Awake()
    {
        Debug.Log("LevelAdvancePanel Awake");
        playerShip.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LevelAdvancePanel Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
