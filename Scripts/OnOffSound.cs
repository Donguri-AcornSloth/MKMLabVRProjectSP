using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSound : MonoBehaviour
{
    public static bool isSound = true;

    public AudioClip OnOffSoundSE;
    private AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton()
    {
        //音・パーティクルを再生
        AudioSource.PlayOneShot(OnOffSoundSE);

        if (isSound == false)
        {
            isSound = true;
        }
        else if (isSound == true)
        {
            isSound = false;
        }
    }
}
