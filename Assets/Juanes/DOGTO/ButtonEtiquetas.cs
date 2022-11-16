using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonEtiquetas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;

    private void Awake()
    {
        textField.text =PlayerPrefs.GetString("etiqueta");
        //textField = GameObject.Find("Etiqueta1").GetComponent<TextMeshProUGUI>();
    }

    public void cambioeTexto1()
    {
        textField.text = "Flojo";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto2()
    {
        textField.text = "Debil";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto3()
    {
        textField.text = "Fuerte";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }

    public void cambioeTexto4()
    {
        textField.text = "Juguet�n";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto5()
    {
        textField.text = "Leal";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto6()
    {
        textField.text = "Dormil�n";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto7()
    {
        textField.text = "Rabioso";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto8()
    {
        textField.text = "Grande";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto9()
    {
        textField.text = "Peque�o";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
    public void cambioeTexto0()
    {
        textField.text = "Gru�on";
        PlayerPrefs.SetString("etiqueta", textField.text);
    }
}
