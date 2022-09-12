using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PantallasContrato : MonoBehaviour
{
    [SerializeField] Eventos contrato;
    [SerializeField] GameObject canvasContrato, canvasNombre;
    [SerializeField] TMP_InputField nombre;
    string nombrePerro;

    void Start()
    {
        contrato.GEvent += Contrato;
    }

   void Contrato()
    {
        canvasNombre.SetActive(true);
    }

    public void OnContinue()
    {
        PlayerPrefs.SetString("NombrePerro", nombre.text);
        canvasNombre.SetActive(false);
        canvasContrato.SetActive(true);
        Debug.Log(PlayerPrefs.GetString("NombrePerro"));
    }

    public void onAcceptContract()
    {
        SceneManager.LoadScene("Main");
    }
}
