using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManagerL : MonoBehaviour
{
    public GameObject bullet;
    public AudioClip audioClip;
    public AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            Instantiate(bullet, transform.position , transform.rotation);//+transform.forward / 2, transform.rotation);

            if (OnOffSound.isSound)
            {
                Audio.PlayOneShot(audioClip);
            }
        }
        //テスト用
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + transform.forward / 2, transform.rotation);
            Audio.PlayOneShot(audioClip);
        }
    }
}
