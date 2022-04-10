using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStage1 : MonoBehaviour
{
    public AudioClip ToStage1SE;
    private AudioSource AudioSource;

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        //音・パーティクルを再生
        AudioSource.PlayOneShot(ToStage1SE);
        SceneManager.LoadScene("Stage1_Test");
    }
}
