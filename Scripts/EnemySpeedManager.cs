using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeedManager : MonoBehaviour
{
    public float triggerSpeed;
    public float setSpeed;
    public float waitTime;

    GameObject enemy;
    Cinemachine.CinemachineDollyCart script;

    void Start()
    {
        enemy = GameObject.Find("Enemy");
        script = enemy.GetComponent<Cinemachine.CinemachineDollyCart>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            script.m_Speed = triggerSpeed;
            StartCoroutine("NextArea");
        }
    }

    IEnumerator NextArea()
    {
        yield return new WaitForSeconds(waitTime);
        script.m_Speed = setSpeed;
    }
}