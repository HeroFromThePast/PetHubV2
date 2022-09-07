using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsyStats : MonoBehaviour
{
    private Vector3 inicialPos;
    [SerializeField] Eventos propEntregado;
    
    void Start()
    {
        propEntregado.GEvent += EntregarProp;
        inicialPos = this.gameObject.transform.position;
    }

    public void EntregarProp()
    {
        this.gameObject.SetActive(false);
        this.gameObject.transform.position = inicialPos;
    }

    private void OnDestroy()
    {
        propEntregado.GEvent -= EntregarProp;
    }
}
