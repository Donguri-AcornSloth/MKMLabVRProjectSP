using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Text;

public class ToStage1 : MonoBehaviour
{
    public AudioClip ToStage1SE;
    private AudioSource AudioSource;

    DateTime dt;

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
