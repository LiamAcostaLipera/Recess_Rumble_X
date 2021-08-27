using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void restartscene()
    {
        SceneManager.LoadScene(0);
    }

    public void CargarTraining()
    {
        SceneManager.LoadScene(0);
    }

    public void CargarIntro()
    {
        SceneManager.LoadScene(1);
    }
}
