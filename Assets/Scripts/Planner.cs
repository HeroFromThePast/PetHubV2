using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Planner : MonoBehaviour
{
    private float timer;
    private bool puedeAparecer = false;
    private bool contando = false;
    private float limiteTimer;
    [SerializeField] GameObject mensajePlanner;
    [SerializeField] GameObject canvasPlanner;
    [SerializeField] TextMeshProUGUI texto1;
    [SerializeField] TextMeshProUGUI textoTarea;

    void Update()
    {
        if (contando) { 
            timer += Time.deltaTime;
        }
        if (timer >= limiteTimer && puedeAparecer)
        {
            AparecerBoton();
            contando = false;
        }
        Debug.Log(timer);
    }

    public void AparecerBoton()    
    {   
        mensajePlanner.SetActive(true);
    }

    public void DesaparecerBoton()
    {
        mensajePlanner.SetActive(false);
        contando = false;
        puedeAparecer = false;
        timer = 0;
    }

    public void Agendar()
    {
        PlayerPrefs.SetString("tarea", textoTarea.text);
        texto1.text = PlayerPrefs.GetString("tarea");
        canvasPlanner.SetActive(false);
        puedeAparecer = true;
        contando = true;
    }

    public void Boton1()
    {
        limiteTimer = 60;
        Debug.Log(limiteTimer);
    }

    public void Boton2()
    {
        limiteTimer = 120;
    }

    public void Boton3()
    {
        limiteTimer = 180;
    }

    public void Boton4()
    {
        limiteTimer = 240;
    }

    public void Boton5()
    {
        limiteTimer = 300;
    }
}
