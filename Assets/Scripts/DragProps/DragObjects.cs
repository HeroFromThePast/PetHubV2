using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObjects : MonoBehaviour
{
    private bool estaPollo = false, estaChocolate = false, estaCuido = false;
    public bool estaArrast = false;
    private Vector3 mOffset;
    private float mZCoord;
    [SerializeField] Estadisticas stats;
    [SerializeField] PropsyStats prop;
    [SerializeField] ActualizarStats actualizar;
    private Vector3 posIni;

    private void Start()
    {
        posIni = this.gameObject.transform.position;
    }
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseUp()
    {
        if (estaPollo)
        {
            prop.EntregarProp();
            stats.aumentoAl = 20;
            stats.disminucionS = 20;
            stats.BajarSalud();
            stats.SubirAlimentacion();
            actualizar.Actualizar();

        }else if (estaChocolate){
            prop.EntregarProp();
            stats.disminucionS = 40;
            stats.BajarSalud();
            actualizar.Actualizar();
        }else if (estaCuido)
        {
            prop.EntregarProp();
            stats.aumentoAl = 40;
            stats.SubirAlimentacion();
            actualizar.Actualizar();
        }
        estaArrast = false;
        this.gameObject.transform.position = posIni;
    }
    private void OnMouseDrag()
    { 
        if(stats.alimentacion <= 99) { 
            transform.position = GetMouseWorldPos() + mOffset;
            estaArrast = true;
        }

    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Pollo") { 
            
                estaPollo = true;
            }else if( this.gameObject.tag == "Chocolate")
            {
                estaChocolate = true;
            }else if (this.gameObject.tag == "Cuido")
            {
                estaCuido = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            estaPollo = false;
            estaChocolate = false;
            estaCuido = false;
        }
    }


}
