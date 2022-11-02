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

    DateTime dt;

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        // Log�p������
        dt = DateTime.Now;
        SaveLog.sw = new StreamWriter("LogData_" + dt.Year.ToString() + "_" + dt.Month.ToString() + "_" + dt.Day.ToString() + "_" + dt.Hour.ToString() + "_" + dt.Minute.ToString() + ".csv", false, Encoding.GetEncoding("Shift_JIS"));

        // ���E�p�[�e�B�N�����Đ�
        AudioSource.PlayOneShot(ToStage2SE);
        SceneManager.LoadScene("ma_Stage3");
    }
}