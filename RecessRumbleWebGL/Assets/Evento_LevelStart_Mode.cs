using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UFE3D;
using UnityEngine.Analytics;

public class Evento_LevelStart_Mode : MonoBehaviour
{
    
    
    public int contadorIndex = 0;

 


    //*************abrir calificaciones post-versus*******************
    public static bool TerminoLaPeleaVersus = false;
    public  GameObject PanelOp;
    public GameObject Panel;

    //*************ver_controles_menu Variables globales*******************
    public static bool AbrirMenu = false;
    public bool activadobotoncontrol = false;

    //*************LevelStart Variables globales*******************
    //LevelIndex
    public GameObject tagStage;
    private int levelindex1_valor;





    //Modos
    public static string ContenedorModo;
    public static bool Check1PVP = false;
    public static bool Check1PVCPU = false;
    public static bool Check1CPUVCPU = false;
    public static bool Check2 = false;


    //Escenario
    public GameObject tagEscenario;







    void Update()
    {

        

    


        if (Check1PVP && Check2 == true){
            string PvsP = "PvsP";
            //Debug.Log("Modo PvsP ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", PvsP}

        });

            Check1PVP = false;
            Check2 = false;
        }

        if (Check1PVCPU && Check2 == true)
        {
            string PvsCPU = "PvsCPU";
            //Debug.Log("Modo PvsCPU ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", PvsCPU}

        });
            Check1PVCPU = false;
            Check2 = false;
        }

        if (Check1CPUVCPU && Check2 == true)
        {
            string CPUvsCPU = "CPUvsCPU";
           // Debug.Log("Modo CPUvCPU ");
            Analytics.CustomEvent("level_start", new Dictionary<string, object>{
        {"modo", CPUvsCPU}  });
            
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

            //Debug.Log("Holis");
            
            TerminoLaPeleaVersus = false;
            AbrirMenu = false;
        } //abrir calificaciones post versus
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
            string menu = "menu";
            Analytics.CustomEvent("ver_controles_menu", new Dictionary<string, object>{
        {"donde", menu}

        });

            activadobotoncontrol = true;
        }
        else
            activadobotoncontrol = false;




    }
 

    public void CambiarValorLevelIndex()
    {
        levelindex1_valor= levelindex1_valor;
    }

  public void PingParaEnviarAnalytic()
    {
        Debug.Log("Analytic Enviadox");
        //ESTE EVENTO TIENE QUE ENVIARSE EN LA PELEA EL PRIMER SEGUNDO


        //Level index
        Debug.Log("LevelIndex= " + levelindex1_valor);
        Debug.Log("Personaje1= " + UFE.config.player1Character.characterName); //personnaje elegido p1
        Debug.Log("Personaje2= " + UFE.config.player2Character.characterName); //personnaje elegido p2
                                                              //Modo   contenedorModo

    }




 

}
