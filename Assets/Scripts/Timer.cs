using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes, seconds;
    [SerializeField] Eventos inicioTimer;
    [SerializeField] Eventos[] evento;
    [SerializeField]int m, s;
    public int mGuardado, sGuardado;
    // Start is called before the first frame update
    void Start()
    {
        inicioTimer.GEvent += StartTimer;

    }
    public void StartTimer() //empieza el contador
    {
        StopTimer();
        RestartTime();
        
        Invoke("UpdateTimer", 1f);
    }
    
    public void StopTimer() //detener el contador
    {
        SaveTime();
        CancelInvoke();
    }
    void UpdateTimer()
    {
        s--;
        if (s < 0)
        {
            if (m == 0)
            {
                for(int i = 0; i < evento.Length; i++)
                {
                    evento[i].FireEvent(); //disparar eventos
                }
                RestartTime();
            }
            else
            {
                m--;
                s = 59;
            }
        }
        Invoke("UpdateTimer", 1f);
    }
    void RestartTime()
    {
        m = minutes;
        s = seconds;
    }
    public void SaveTime()
    {
        PlayerPrefs.SetInt("minutos previos", m);
        PlayerPrefs.SetInt("segundos previos", s);
    }
    private void OnDestroy()
    {
        inicioTimer.GEvent -= StartTimer;
    }
}
