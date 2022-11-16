using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EtiqChange3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField3;

    private void Start()
    {
        textField3.text = PlayerPrefs.GetString("etiqueta3");
        //textField = GameObject.Find("Etiqueta1").GetComponent<TextMeshProUGUI>();
    }

    public void cambioeTexto1()
    {
        textField3.text = "Flojo";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto2()
    {
        textField3.text = "Debil";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto3()
    {
        textField3.text = "Fuerte";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }

    public void cambioeTexto4()
    {
        textField3.text = "Juguetón";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto5()
    {
        textField3.text = "Leal";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto6()
    {
        textField3.text = "Dormilón";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto7()
    {
        textField3.text = "Rabioso";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto8()
    {
        textField3.text = "Grande";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto9()
    {
        textField3.text = "Pequeño";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
    public void cambioeTexto0()
    {
        textField3.text = "Gruñon";
        PlayerPrefs.SetString("etiqueta3", textField3.text);
    }
}
