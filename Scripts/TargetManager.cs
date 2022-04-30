using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int TriggerCounter;
    public AudioClip SE;
    public AudioSource Audio;
    public ParticleSystem Particle1;
    public ParticleSystem particle2;
    public GameObject otherObj;
    public int Timer;
    public int DestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        //当たった回数の初期値設定
        TriggerCounter = 0;
        Audio = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void fixedUpdate()
    {
        //当たった後にタイマーを起動
        if(TriggerCounter>=1)
        {
            Timer += 1;
        }
        //指定秒後に削除
        if(Timer>=DestroyTime*50)
        {
            Destroy(gameObject);
            Destroy(otherObj.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject newParticle1;
        GameObject newParticle2;

        if (other.gameObject.CompareTag("Bullet"))
        {
            //当たったオブジェクトの情報を取得
            otherObj = other.gameObject;
            //当たった回数を追加
            TriggerCounter += 1;
            //当たり判定とレンダラーを無効化
            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            otherObj.GetComponent<Collider>().enabled = false;
            otherObj.GetComponent<Collider>().enabled = false;

            //音・パーティクルを再生
            if (OnOffSound.isSound)
            {
                Audio.PlayOneShot(SE);
            }

            newParticle1 = Instantiate(Particle1.gameObject);
            newParticle1.GetComponent<ParticleSystem>().Play();
            newParticle2 = Instantiate(Particle1.gameObject);
            newParticle2.GetComponent<ParticleSystem>().Play();

            // TargetとBulletを両方消去
            /*Destroy(gameObject);
            Destroy(other.gameObject);*/

            // 得点を追加
            scoreManager.AddScore();
        }
    }
}
