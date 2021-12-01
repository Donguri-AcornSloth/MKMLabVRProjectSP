using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManagerL : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            Instantiate(bullet, transform.position + transform.forward / 2, transform.rotation);
        }
    }
}
