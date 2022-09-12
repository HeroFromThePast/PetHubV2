using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsyStats : MonoBehaviour
{
    [SerializeField] Eventos propEntregado;
    
    void Start()
    {
        propEntregado.GEvent += EntregarProp;
    }

    public void EntregarProp()
    {
        this.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        propEntregado.GEvent -= EntregarProp;
    }
}
