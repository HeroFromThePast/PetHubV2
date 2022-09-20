using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitadorFPS : MonoBehaviour
{
    private int limiteFPS = 60;
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = limiteFPS;
    }
}
