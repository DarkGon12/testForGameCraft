using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform moneyPref;

    void Awake()
    {
        MoneySpawn();
    }

    void MoneySpawn()
    {
        if (Random.Range(0, 60) < 20)
        {
            Instantiate(moneyPref, gameObject.transform.position, Quaternion.identity);
        }
    }
}
