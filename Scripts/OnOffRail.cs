using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffRail : MonoBehaviour
{
    public static bool isRail = false;

    public AudioClip OnOffRailSE;
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
        AudioSource.PlayOneShot(OnOffRailSE);

        if (isRail == false)
        {
            isRail = true;
        }
        else if (isRail == true)
        {
            isRail = false;
        }
    }
}
