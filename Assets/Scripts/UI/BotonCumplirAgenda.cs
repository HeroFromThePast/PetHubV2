using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCumplirAgenda : MonoBehaviour
{
    [SerializeField] Eventos aparecer,desaparecer,recompensa;
    [SerializeField] float aparicionBoton;
    void Awake()
    {
        transform.localScale = Vector2.zero;
        aparecer.GEvent += AparecerBoton;
        desaparecer.GEvent += DesaparecerBoton;
    }

    void AparecerBoton()
    {
        transform.LeanScale(Vector2.one, aparicionBoton).setEaseOutQuart();
    }
    void DesaparecerBoton()
    {
        transform.LeanScale(Vector2.zero, aparicionBoton).setEaseOutQuart();
    }
    public void DispararYDesaparecer()
    {
        recompensa.FireEvent();
        desaparecer.FireEvent();
    }
    private void OnDestroy()
    {
        aparecer.GEvent -= AparecerBoton;
        desaparecer.GEvent -= DesaparecerBoton;
    }
}
