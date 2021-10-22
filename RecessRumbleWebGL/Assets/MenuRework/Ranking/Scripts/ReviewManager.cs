using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine;

public class ReviewManager : MonoBehaviour
{
    private int stars;
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        stars = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStars(int _count)
    {
        stars = _count;
    }

    public int GetStars()
    {
        return stars;
    }

    public void Send()
    {
       if(stars != -1)
        {
           Analytics.CustomEvent("calificacion", new Dictionary<string, object>{
             {"nota", stars}
          });
            Debug.Log( stars);
        }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }
}
