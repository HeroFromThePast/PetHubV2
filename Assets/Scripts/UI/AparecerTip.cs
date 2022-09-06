using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerTip : MonoBehaviour
{
    [SerializeField] float duracionTip,aparicionTip;
    [SerializeField] Eventos aparecerTip, desaparecerTip;
    [SerializeField] Vector2 posicionNueva,posicionInicial;
    void Start()
    {
        transform.localScale = Vector2.zero;
        transform.localPosition = posicionInicial;
        aparecerTip.GEvent += AparecerMensaje;
        desaparecerTip.GEvent += Desaparecer;
    }

    void AparecerMensaje()
    {
        
        transform.LeanScale(Vector2.one, aparicionTip).setEaseOutQuart();
        transform.LeanMoveLocal(posicionNueva, aparicionTip / 2).setEaseOutQuart();
        StartCoroutine("DesaparecerMensaje");
    }
    IEnumerator DesaparecerMensaje()
    {
        yield return new WaitForSeconds(duracionTip);
        Desaparecer();
    }
    void Desaparecer()
    {
        transform.LeanScale(Vector2.zero, aparicionTip).setEaseOutQuart();
        transform.LeanMoveLocal(posicionInicial, aparicionTip / 2).setEaseOutQuart();
        
    }
    private void OnDestroy()
    {
        aparecerTip.GEvent -= AparecerMensaje;
        desaparecerTip.GEvent -= Desaparecer;
    }
}
