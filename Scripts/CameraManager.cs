using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject vrCam;
    public GameObject mainCam;

    private Camera vrCamComp;
    private Camera mainCamComp;

    // Start is called before the first frame update
    void Start()
    {
        vrCamComp = vrCam.GetComponent<Camera>();
        mainCamComp = mainCam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TPSTriggerIn"))
        {
            Debug.Log("In");
            vrCamComp.enabled = false;
            mainCamComp.enabled = true;
        }

        if (other.gameObject.CompareTag("TPSTriggerOut"))
        {
            Debug.Log("Out");
            vrCamComp.enabled = true;
            mainCamComp.enabled = false;
        }
    }
}
