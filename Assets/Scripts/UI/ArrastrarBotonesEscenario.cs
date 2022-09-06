using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastrarBotonesEscenario : MonoBehaviour
{
    [SerializeField] float aparicionBoton;
    [SerializeField] Vector2 posicionNueva, posicionInicial;
    [SerializeField] Eventos aparicion, desaparicion;

    void Start()
    {
        transform.localPosition = posicionInicial;
        aparicion.GEvent += ArrastrarBoton;
        desaparicion.GEvent += DesaparecerBoton;
    }

    void ArrastrarBoton()
    {
        transform.LeanMoveLocal(posicionNueva, aparicionBoton).setEaseOutQuart();
    }
    void DesaparecerBoton()
    {
        transform.LeanMoveLocal(posicionInicial, aparicionBoton).setEaseOutQuart();
    }
    private void OnDestroy()
    {
        aparicion.GEvent -= ArrastrarBoton;
        desaparicion.GEvent -= DesaparecerBoton;
    }
}
