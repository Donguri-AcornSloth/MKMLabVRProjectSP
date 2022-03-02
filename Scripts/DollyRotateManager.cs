using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyRotateManager : MonoBehaviour
{
    public GameObject dolly;
    CartManager  script;
    public float triggerPitch;
    public float triggerYaw;
    public float triggerRoll;

    // Start is called before the first frame update
    void Start()
    {
        //dolly = GameObject.Find("Dolly");
        script = dolly.GetComponent<CartManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            script.pitch = triggerPitch;
            script.yaw = triggerYaw;
            script.roll = triggerRoll;
        }
    }
}