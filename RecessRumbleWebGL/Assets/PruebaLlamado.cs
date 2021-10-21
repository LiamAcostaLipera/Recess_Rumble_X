using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaLlamado : MonoBehaviour
{
    int CantidadEscenarios;

    // Start is called before the first frame update
    void Start()
    {
        Object[] cantidad = GameObject.FindGameObjectsWithTag(gameObject.tag);

        foreach (GameObject Escenario in cantidad)
        {
            if (CantidadEscenarios < 1)
            {
                CantidadEscenarios++;                   // Por cada objeto que haya, suma 1 a la variable
                Debug.Log("escenario " + gameObject.tag);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
