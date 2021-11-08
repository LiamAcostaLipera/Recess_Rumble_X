using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Evento_LevelStart_Mode : MonoBehaviour
{

    public static bool Check1PVP = false;
    public static bool Check1PVCPU = false;
    public static bool Check1CPUVCPU = false;
    public static bool Check2 = false;

    public int contadorIndex = 0;

    public static bool TerminoLaPeleaVersus = false;
    public  GameObject PanelOp;

    public  bool activadobotoncontrol = false;
    public static bool AbrirMenu = false;
    public GameObject Panel;

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


        if(TerminoLaPeleaVersus == true && AbrirMenu == true) {


            Panel.SetActive(true);
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }


            Debug.Log("Holis");
            

            TerminoLaPeleaVersus = false;
            AbrirMenu = false;

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
        AbrirMenu = false;
    }

    public void AbrirMenuPrincipal()
    {
        AbrirMenu = true;
    }


    


    public void ver_controles_menu()
    {
        if (activadobotoncontrol == false)
        {
            Analytics.CustomEvent("ver_controles_menu", new Dictionary<string, object>{
        {"donde", "menu"}

        });

            activadobotoncontrol = true;
        }
        else
            activadobotoncontrol = false;




    }
 

}
