using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollySpeedManager : MonoBehaviour
{
    GameObject player;
    Cinemachine.CinemachineDollyCart script;
    public float triggerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<Cinemachine.CinemachineDollyCart>();
        //script.m_Speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(script.m_Speed);
        //script.m_Speed = 5;
    }

    /**void OnCollisionEnter(Collision other)
    {
        Debug.Log("a");
        script.m_Speed = 5;
    }**/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //Debug.Log("a");
            Debug.Log(script.m_Speed);
            script.m_Speed = triggerSpeed;
        }
    }
}
