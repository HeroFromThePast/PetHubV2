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
        transform.localScale = Vector2.zero;
        transform.localPosition = posicionInicial;
        //transform.localPosition = posicionInicial;
        aparicion.GEvent += ArrastrarBoton;
        desaparicion.GEvent += DesaparecerBoton;
    }

    void ArrastrarBoton()
    {
        transform.LeanScale(Vector2.one, aparicionBoton).setEaseOutQuart();
        transform.LeanMoveLocal(posicionNueva, aparicionBoton).setEaseOutQuart();
    }
    void DesaparecerBoton()
    {
        transform.LeanScale(Vector2.zero, aparicionBoton).setEaseOutQuart();
        transform.LeanMoveLocal(posicionInicial, aparicionBoton).setEaseOutQuart();
    }
    private void OnDestroy()
    {
        aparicion.GEvent -= ArrastrarBoton;
        desaparicion.GEvent -= DesaparecerBoton;
    }
}
