using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyStopTrigger : MonoBehaviour
{
    public float triggerSpeed;
    public float waitTime;
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
        if (other.gameObject.CompareTag("Player"))
        {
            script.m_Speed = 0f;
            StartCoroutine("Resume");
            //script.m_Speed = triggerSpeed;
        }
    }
    IEnumerator Resume()
    {
        yield return new WaitForSeconds(waitTime);
        script.m_Speed = triggerSpeed;
    }
}