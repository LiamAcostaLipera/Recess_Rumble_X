using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Evento_LevelStart_Mode : MonoBehaviour
{

    public static bool Check1PVP = false;
    public static bool Check1PVCPU = false;
    public static bool Check1CPUVCPU = false;
    public static bool Check2 = false;

    public int contadorIndex = 0;

    public static bool TerminoLaPeleaVersus = false;
    public  GameObject PanelOp;
    

    void Update()
    {
        if (Check1PVP && Check2 == true){
            //Debug.Log("Modo PvsP ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", "PvsP"}

        });

            Check1PVP = false;
            Check2 = false;
        }

        if (Check1PVCPU && Check2 == true)
        {
            //Debug.Log("Modo PvsCPU ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", "PvsCPU"}

        });
            Check1PVCPU = false;
            Check2 = false;
        }

        if (Check1CPUVCPU && Check2 == true)
        {
           // Debug.Log("Modo CPUvCPU ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", "CPUvsCPU"}  });
            
            Check1CPUVCPU = false;
            Check2 = false;
        }

    }

    public void FirstCheckPVP()
    {
        Check1PVP = true;
    }

    public void FirstCheckPVCPU()
    {
        Check1PVCPU = true;
    }

    public void FirstCheckCPUVCPU()
    {
        Check1CPUVCPU = true;
    }

    public void SecondCheck()
    {
        Check2 = true;
    }

    public void abrirCalificacionesVersus()
    {
        TerminoLaPeleaVersus = true;
    }

    public void ContarIndex()
    {

    }





}
