using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text _rateUI;
    public int _rate;
    public GameObject _deadPanel;

    public Controller _hero;

    void FixedUpdate()
    {
        _rateUI.text = _rate.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hero")
        {
            _hero.enabled = false;
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _deadPanel.SetActive(true);
        }
    }
}
