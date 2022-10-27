using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transicionEscenas : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AnimationClip animacionFinal;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Patio()
    {
        StartCoroutine(CambiarEscena());
    }

    IEnumerator CambiarEscena()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("Patio");
        Time.timeScale = 1f;
    }

    public void Main()
    {
        StartCoroutine(CambiarEscena2());
    }

    IEnumerator CambiarEscena2()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }
    public void Sala()
    {
        StartCoroutine(CambiarEscena3());
    }

    IEnumerator CambiarEscena3()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("Sala");
        Time.timeScale = 1f;
    }

    public void FAQ_Camb()
    {
        StartCoroutine(FAQ_Change());
    }

    IEnumerator FAQ_Change()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("FAQ");
        Time.timeScale = 1f;
    }

    public void Agenda_Camb()
    {
        StartCoroutine(Agenda_Change());
    }

    IEnumerator Agenda_Change()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("Agenda");
        Time.timeScale = 1f;
    }
}
