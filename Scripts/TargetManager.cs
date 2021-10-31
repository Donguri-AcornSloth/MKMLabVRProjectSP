using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // TargetとBulletを両方消去
            Destroy(gameObject);
            Destroy(collision.gameObject);

            // 得点を追加
            scoreManager.AddScore();
        }
    }
}
