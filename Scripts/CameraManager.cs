using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    public GameObject rootObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (OnOffTPS.isTPS == true)
        {
            if (other.gameObject.CompareTag("TPSTriggerIn"))
            {
                player.transform.localPosition = new Vector3(0f, 4f, 1.8f);
                //player.transform.localEulerAngles = new Vector3(100, 0, 0);
                //player.gameObject.transform.parent = rootObject.gameObject.transform;
            }

            if (other.gameObject.CompareTag("TPSTriggerOut"))
            {
                //player.gameObject.transform.parent = this.gameObject.transform;
                player.transform.localPosition = new Vector3(0f, -0.35f, 1.8f);
                //player.transform.localEulerAngles = new Vector3(90, 0, 0);
            }
        }
    }
}
