using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClick : MonoBehaviour
{
    public GameObject panel;

    public Controller _hero;

    private void Awake()
    {
        _hero.enabled = false;
        Time.timeScale = 0f;
    }

    void Update()
    {
        if(Input.GetMouseButton(0) & panel.activeSelf == true)
        {
            _hero.enabled = true;
            panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
