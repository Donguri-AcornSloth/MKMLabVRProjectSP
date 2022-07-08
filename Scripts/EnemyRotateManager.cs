using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateManager : MonoBehaviour
{

    GameObject enemy;
    RotateUnit script;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("RotateEnemy");
        script = enemy.GetComponent<RotateUnit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

        }
    }
}
