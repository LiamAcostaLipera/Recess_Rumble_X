using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PruebaLlamado : MonoBehaviour
{
    public GameObject tagEscenario;
    int CantidadEscenarios;

    // Start is called before the first frame update
    void Start()
    {
        Object[] cantidad = GameObject.FindGameObjectsWithTag(gameObject.tag);

        foreach (GameObject Escenario in cantidad)
        {
            if (CantidadEscenarios < 1)
            {
                CantidadEscenarios++;

                Analytics.CustomEvent("level_start", new Dictionary<string, object>{
            {"escenario ", gameObject.tag}
             });
                //Debug.Log("escenario " + gameObject.tag);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
