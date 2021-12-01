using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float deleteTime;

    private Rigidbody rb;
    private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 5.0f;

        // 指定時間後に消去
        Destroy(gameObject, deleteTime);
    }

    void Update()
    {
        // 正面に発射
        rb.velocity = transform.forward * speed;
    }
}
