using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManagerR : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        }
    }
}
