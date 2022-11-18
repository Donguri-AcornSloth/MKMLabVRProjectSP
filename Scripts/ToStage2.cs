using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Text;

public class ToStage2 : MonoBehaviour
{
    public AudioClip ToStage2SE;
    private AudioSource AudioSource;

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        // ���E�p�[�e�B�N�����Đ�
        AudioSource.PlayOneShot(ToStage2SE);
        SceneManager.LoadScene("ma_Stage2");
    }
}