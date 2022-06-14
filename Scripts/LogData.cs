using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogData : MonoBehaviour
{
    public static int score = 0;
    public static int bulletCount;
    public static Vector3 movement;
    public static Vector3 rotation;

    private Vector3 pmovement;
    private Vector3 protation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement += this.gameObject.transform.position - pmovement;
        rotation += this.gameObject.transform.rotation.eulerAngles - protation;

        pmovement = this.gameObject.transform.position;
        protation = this.gameObject.transform.rotation.eulerAngles;
    }
}
