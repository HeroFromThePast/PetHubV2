using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public Animator anim;
    public string escenaSiguiente;
    public bool verificarTutorial;
    float timer = 0;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            LoadScene();
            timer = 0;
        }
    }
    public void LoadScene()
    {
        if (verificarTutorial == true)
        {
            if (PlayerPrefs.GetInt("PrimeraVez") == 0)
            {
                StartCoroutine(Load("Tutorial"));
                //PlayerPrefs.SetInt("PrimeraVez", 1);
            }
            else
            {
                StartCoroutine(Load(escenaSiguiente));
            }
        }
        else
        {
            StartCoroutine(Load(escenaSiguiente));
        }
        
        
    }
    IEnumerator Load(string escena)
    {
        anim.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(escena);
    }
}
