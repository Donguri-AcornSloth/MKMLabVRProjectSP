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

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        //���E�p�[�e�B�N�����Đ�
        AudioSource.PlayOneShot(ToStage1SE);
        SceneManager.LoadScene("ma_Stage1");
    }
}
