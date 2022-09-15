using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEscenarios : MonoBehaviour
{
    [SerializeField] Eventos escP,escS,escT;
    [SerializeField] Vector3[] posicionInicial;
    [SerializeField] Vector3[] posicionJuego;
    [SerializeField] GameObject[] escenarios;
    public int escenariosActual,escenarioNuevo;
    [SerializeField] float tiempoDeCambio;
    [SerializeField] GameObject pollo, chocolate, cuido;
    void Start()
    {
        //CambiarEscenario(Random.Range(0,3));
        CambiaraPrimero();
        tiempoDeCambio = 0;
        escP.GEvent += CambiaraPrimero;
        escS.GEvent += CambiaraSegundo;
        escT.GEvent += CambiaraTercero;
        
    }

    void CambiaraPrimero()
    {
        escenarioNuevo = 0;
        CambiarEscenario(escenarioNuevo);
        pollo.SetActive(true);
        chocolate.SetActive(true);
        cuido.SetActive(true);
    }
    void CambiaraSegundo()
    {
       
        escenarioNuevo = 1;
        CambiarEscenario(escenarioNuevo);
    }
    void CambiaraTercero()
    {
        escenarioNuevo = 2;
        CambiarEscenario(escenarioNuevo);
    }
    void CambiarEscenario(int escenarionuevo)
    {
        tiempoDeCambio = 2;
        if (escenarionuevo != escenariosActual)
        {
            escenarios[escenariosActual].transform.LeanMoveLocal(posicionInicial[escenariosActual], tiempoDeCambio).setEaseOutQuart();
            //LeanTween.move(escenarios[escenariosActual], posicionInicial[escenariosActual],tiempoDeCambio).setEaseOutQuart();
            
            escenarios[escenarionuevo].transform.LeanMoveLocal(posicionJuego[escenarionuevo], tiempoDeCambio).setEaseOutQuart();
            //LeanTween.move(escenarios[escenarionuevo], posicionJuego, tiempoDeCambio).setEaseOutQuart();
            
            escenariosActual = escenarionuevo;
        }
    }
    private void OnDestroy()
    {
        escP.GEvent -= CambiaraPrimero;
        escS.GEvent -= CambiaraSegundo;
        escT.GEvent -= CambiaraTercero;
    }
}
