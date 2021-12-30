using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollySpeedManager : MonoBehaviour
{
    public GameObject player;
    Cinemachine.CinemachineDollyCart script;
    public float triggerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        script = player.GetComponent<Cinemachine.CinemachineDollyCart>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log(script.m_Speed);
            script.m_Speed = triggerSpeed;
        }
    }
}
