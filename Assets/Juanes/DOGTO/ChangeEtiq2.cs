using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeEtiq2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField2;

    private void Start()
    {
        textField2.text = PlayerPrefs.GetString("etiqueta2");
        //textField = GameObject.Find("Etiqueta1").GetComponent<TextMeshProUGUI>();
    }

    public void cambioeTexto1()
    {
        textField2.text = "Flojo";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto2()
    {
        textField2.text = "Debil";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto3()
    {
        textField2.text = "Fuerte";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }

    public void cambioeTexto4()
    {
        textField2.text = "Juguetón";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto5()
    {
        textField2.text = "Leal";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto6()
    {
        textField2.text = "Dormilón";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto7()
    {
        textField2.text = "Rabioso";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto8()
    {
        textField2.text = "Grande";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto9()
    {
        textField2.text = "Pequeño";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
    public void cambioeTexto0()
    {
        textField2.text = "Gruñon";
        PlayerPrefs.SetString("etiqueta2", textField2.text);
    }
}
