using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotPaused : MonoBehaviour
{
    public GameObject pauseMenuUI;
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    
}
