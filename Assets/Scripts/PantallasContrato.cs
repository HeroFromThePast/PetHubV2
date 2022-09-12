using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PantallasContrato : MonoBehaviour
{
    [SerializeField] Eventos contrato;
    [SerializeField] GameObject canvasContrato, canvasNombre,tutorial;
    [SerializeField] TMP_InputField nombre;
    string nombrePerro;

    void Start()
    {
        contrato.GEvent += Contrato;
        canvasNombre.transform.localScale = Vector3.zero;
        canvasContrato.transform.localScale = Vector3.zero;
    }

   void Contrato()
    {
        tutorial.LeanScale(Vector3.zero, 1f).setEaseInOutQuart();
        canvasNombre.LeanScale(Vector3.one, 1f).setEaseInOutQuart();
    }

    public void OnContinue()
    {
        PlayerPrefs.SetString("NombrePerro", nombre.text);
        canvasNombre.LeanScale(Vector3.zero,1f).setEaseInOutQuart();
        
        canvasContrato.LeanScale(Vector3.one, 1f).setEaseInOutQuart();
        Debug.Log(PlayerPrefs.GetString("NombrePerro"));
    }

    public void onAcceptContract()
    {
        SceneManager.LoadScene("Main");
    }
    private void OnDestroy()
    {
        contrato.GEvent -= Contrato;
    }
}
