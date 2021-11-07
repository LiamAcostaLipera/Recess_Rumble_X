using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Evento_mute : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {       

    }

    // Update is called once per frame
    void Update()
    {
        //debug.log("mute en menu");
            Analytics.CustomEvent("mute", new Dictionary<string, object>{
            {"donde ", "menu"}
        });
        
        //debug.log("mute en pausa");
            Analytics.CustomEvent("mute", new Dictionary<string, object>{
            {"donde ", "pausa"}
        });
    }
}
