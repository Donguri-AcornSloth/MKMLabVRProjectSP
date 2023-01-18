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
    void FixedUpdate()
    {

        movement = this.gameObject.transform.localPosition - pmovement;
        rotation = this.gameObject.transform.localRotation.eulerAngles - protation;
        if (rotation.x > 180)
        {
            rotation.x = rotation.x - 360;
        }
        else if (rotation.x < -180)
        {
            rotation.x = rotation.x + 360;
        }
        if (rotation.y > 180)
        {
            rotation.y = rotation.y - 360;
        }
        else if (rotation.y < -180)
        {
            rotation.y = rotation.y + 360;
        }
        if (rotation.z > 180)
        {
            rotation.z = rotation.z - 360;
        }
        else if (rotation.z < -180)
        {
            rotation.z = rotation.z + 360;
        }

        pmovement = this.gameObject.transform.localPosition;
        protation = this.gameObject.transform.localRotation.eulerAngles;
    }
}
