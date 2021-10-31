using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        /*if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        }*/

        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        }
    }
}
