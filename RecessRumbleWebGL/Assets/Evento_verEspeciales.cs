﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class Evento_verEspeciales : MonoBehaviour
{
    public Text namePlayer1;

    // Start is called before the first frame update
    void Start()
    {
        /*Analytics.CustomEvent("ver_especiales", new Dictionary<string, object>{
        {"protagonista",  UFE.config.player1Character.characterName}

        });*/
        CustomEvent verespeciales = new CustomEvent("ver_especiales")
        {
         { "protagonista", UFE.config.player1Character.characterName}

        };

        AnalyticsService.Instance.RecordEvent(verespeciales);

        AnalyticsService.Instance.CustomData("ver_especiales", new Dictionary<string, object>{
        {"protagonista",  UFE.config.player1Character.characterName}

        });
        //Debug.Log("hola " + UFE.config.player1Character.characterName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
