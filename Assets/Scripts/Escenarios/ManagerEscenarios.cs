using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEscenarios : MonoBehaviour
{
    [SerializeField] Eventos escP,escS,escT;
    [SerializeField] Vector3[] posicionInicial;
    [SerializeField] Vector3 posicionJuego;
    [SerializeField] GameObject[] escenarios;
    [SerializeField] int escenariosActual,escenarioNuevo;
    [SerializeField] float tiempoDeCambio;
    void Start()
    {
        
        escP.GEvent += CambiaraPrimero;
        escS.GEvent += CambiaraSegundo;
        escT.GEvent += CambiaraTercero;
        
    }

    void CambiaraPrimero()
    {
        escenarioNuevo = 0;
        CambiarEscenario(escenarioNuevo);
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
        if (escenarionuevo != escenariosActual)
        {
            escenarios[escenariosActual].transform.LeanMoveLocal(posicionInicial[escenariosActual], tiempoDeCambio).setEaseOutQuart();
            //LeanTween.move(escenarios[escenariosActual], posicionInicial[escenariosActual],tiempoDeCambio).setEaseOutQuart();
            
            escenarios[escenarionuevo].transform.LeanMoveLocal(posicionJuego, tiempoDeCambio).setEaseOutQuart();
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
