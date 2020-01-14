using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject sphere;
    private Vector3 direct;
    public float speed;
    public int turn;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            turn++;
        }

        if(turn == 2)
        {
            turn = 0;
        }

        if (turn == 0)
        {
            direct.Set(1f, 0, 0);
        }

        if(turn == 1)
        {
            direct.Set(0, 0, 1);
        }


        transform.Translate(direct.normalized * speed);
    }
}
