using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffTPS : MonoBehaviour
{
    public static bool isTPS = false;

    public AudioClip OnOffTPSSE;
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
        AudioSource.PlayOneShot(OnOffTPSSE);

        if (isTPS == false)
        {
            isTPS = true;
        }
        else if (isTPS == true)
        {
            isTPS = false;
        }
    }
}
