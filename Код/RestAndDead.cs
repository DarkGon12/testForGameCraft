using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestAndDead : MonoBehaviour
{
    private GameObject _hero;
    public Transform spawn;

    private void Start()
    {
        _hero = GameObject.FindWithTag("hero");
    }

    public void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0); // Для того что бы в будущем можно было рестартить лвл без изменения кода
        _hero.transform.position = spawn.transform.position;
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
