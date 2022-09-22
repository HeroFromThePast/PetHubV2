using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenarios : MonoBehaviour
{
    [SerializeField] Eventos escP,escS,escT;
    public int escenariosActual,escenarioNuevo;
    [SerializeField] GameObject pollo, chocolate, cuido;
    [SerializeField] cargarEscena cargarEscenas;
    void Start()
    {
        escP.GEvent += CambiaraPrimero;
        escS.GEvent += CambiaraSegundo;
        escT.GEvent += CambiaraTercero;
        
    }

    void CambiaraPrimero()
    {
        escenarioNuevo = 0;
        CambiarEscenario(escenarioNuevo, "Main");
        pollo.SetActive(true);
        chocolate.SetActive(true);
        cuido.SetActive(true);
    }
    void CambiaraSegundo()
    {
       
        escenarioNuevo = 1;
        CambiarEscenario(escenarioNuevo, "Sala");
        pollo.SetActive(false);
        chocolate.SetActive(false);
        cuido.SetActive(false);
    }
    void CambiaraTercero()
    {
        escenarioNuevo = 2;
        CambiarEscenario(escenarioNuevo, "Patio");
        pollo.SetActive(false);
        chocolate.SetActive(false);
        cuido.SetActive(false);
    }
    void CambiarEscenario(int escenarionuevo, string nombreEscenario)
    {
        cargarEscenas.nombreEscena = nombreEscenario;
        cargarEscenas.CargarEscena();

    }
    private void OnDestroy()
    {
        escP.GEvent -= CambiaraPrimero;
        escS.GEvent -= CambiaraSegundo;
        escT.GEvent -= CambiaraTercero;
    }
}
