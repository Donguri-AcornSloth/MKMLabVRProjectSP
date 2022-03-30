using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTripMove : MonoBehaviour
{
    int counter = 0;
    public float move = 0.05f;
    public int range = 100;

    void Update()
    {
        Vector3 p = new Vector3(0, move, 0);
        transform.Translate(p);
        counter++;

        //countが100になれば-1を掛けて逆方向に動かす
        if (counter == range)
        {
            counter = 0;
            move *= -1;
        }
    }
}
