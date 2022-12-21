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

    //コルーチン用変数
    public float disappearTime = 1;
    public float appearTime = 3;
    public int hitNum = 1;


    // Start is called before the first frame update
    void Start()
    {
        //当たった回数の初期値設定
        TriggerCounter = 0;
        Audio = this.gameObject.GetComponent<AudioSource>();
    }

    void fixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject newParticle1;
        GameObject newParticle2;

        if (other.gameObject.CompareTag("Bullet"))
        {
            //当たった回数を追加
            TriggerCounter += 1;

            //音・パーティクルを再生
            if (OnOffSound.isSound)
            {
                Audio.PlayOneShot(SE);
            }

            newParticle1 = Instantiate(Particle1.gameObject);
            newParticle1.GetComponent<ParticleSystem>().Play();
            newParticle2 = Instantiate(Particle1.gameObject);
            newParticle2.GetComponent<ParticleSystem>().Play();

            if(TriggerCounter >= hitNum)
            {
                StartCoroutine(Control(disappearTime, appearTime));
            }

            // 得点を追加
            scoreManager.AddScore();
        }
    }

    private IEnumerator Control(float disappearTime, float appearTime)
    {
        yield return new WaitForSeconds(disappearTime);

        //当たり判定とレンダラーを無効化
        this.gameObject.GetComponent<Collider>().enabled = false;
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(appearTime);

        //当たり判定とレンダラーを有効化
        this.gameObject.GetComponent<Collider>().enabled = true;
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
