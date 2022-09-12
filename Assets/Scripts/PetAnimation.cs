using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetAnimation : MonoBehaviour
{
    [SerializeField] Eventos pedigree, pollo, chocolate;
    
    private void Start()
    {
        pedigree.GEvent += PedigreeEntregado;
        pollo.GEvent += PolloEntregado;
        chocolate.GEvent += ChocolateEntregado;
    }

    void PedigreeEntregado()
    {

    }

    void PolloEntregado()
    {

    }

    void ChocolateEntregado()
    {

    }
}
