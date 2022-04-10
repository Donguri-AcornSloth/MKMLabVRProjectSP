using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStageSelect : MonoBehaviour
{
    public AudioClip ToStageSelectSE;
    private AudioSource AudioSource;

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        //音・パーティクルを再生
        AudioSource.PlayOneShot(ToStageSelectSE);
        SceneManager.LoadScene("StageSelection");
    }
}
