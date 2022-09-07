using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObjects : MonoBehaviour
{
    private bool estaDentro = false;
    public bool estaArrast = false;
    private Vector3 mOffset;
    private float mZCoord;
    [SerializeField] Estadisticas stats;
    [SerializeField] PropsyStats prop;
    [SerializeField] ActualizarStats actualizar;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseUp()
    {
        if (estaDentro)
        {
            prop.EntregarProp();
            stats.aumentoAl = 20;
            stats.disminucionS = 20;
            stats.BajarSalud();
            stats.SubirAlimentacion();
            actualizar.Actualizar();

        }
        estaArrast = false;
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
            estaDentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            estaDentro = false;
        }
    }


}
