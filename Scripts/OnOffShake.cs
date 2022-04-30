using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffShake : MonoBehaviour
{
    public static bool isShake = false;

    public AudioClip OnOffShakeSE;
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
        //âπÇçƒê∂
        AudioSource.PlayOneShot(OnOffShakeSE);

        if (isShake == false)
        {
            isShake = true;
        }
        else if (isShake == true)
        {
            isShake = false;
        }
    }
}
