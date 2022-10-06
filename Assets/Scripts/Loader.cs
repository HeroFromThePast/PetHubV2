using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public Animator anim;
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
        StartCoroutine(Load(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator Load(int index)
    {
        anim.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(index);
    }
}
