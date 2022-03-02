using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollySpeedManager : MonoBehaviour
{
    public float triggerSpeed;
    GameObject dolly;
    Cinemachine.CinemachineDollyCart script;

    void Start()
    {
        dolly = GameObject.Find("Dolly");
        script = dolly.GetComponent<Cinemachine.CinemachineDollyCart>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            script.m_Speed = triggerSpeed;
        }
    }
}
