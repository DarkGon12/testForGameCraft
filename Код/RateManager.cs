using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateManager : MonoBehaviour
{
    private GameObject _money;
    private Manager manager;
    public AudioSource pick;

    void Start()
    {
        manager = FindObjectOfType<Manager>();
        _money = gameObject;
    }
    
    void Turn()
    {
        _money.transform.Rotate(0, 2, 0 * Time.deltaTime);
    }

    void Update()
    {
        Turn();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hero")
        {
            pick.Play();
            manager._rate++;
            Destroy(_money, 0.37f);
        }
    }
}
