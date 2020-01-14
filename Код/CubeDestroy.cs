using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{
    public Transform pref;
    private Transform cube;


    public void Start()
    {
        cube = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "hero")
        {
            Destroy(gameObject);
            Instantiate(pref, cube.transform.position, Quaternion.identity);
        }
    }
}
