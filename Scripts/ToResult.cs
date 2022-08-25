using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class ToResult : MonoBehaviour
{
    // ���񐔊֘A�̕ϐ�
    public int lapCount;
    public int maxLap = 3;

    // Log�p�ϐ�
    public static bool finish = false;

    // Log�o�͗p�ϐ�
    // score
    // bulletCount

    public SaveLog saveLog;

    public void Start()
    {
        //DateTime now = DateTime.Now;
        //fi = new FileInfo(Application.dataPath + "/" + "LogData_" + now.Year.ToString() + "_" + now.Month.ToString() + "_" + now.Day.ToString() + "__" + now.Hour.ToString() + "_" + now.Minute.ToString() + ".csv");
    }

    public void FixedUpdate()
    {

    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("Result");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // ���񐔂��J�E���g
            lapCount++;

            if (lapCount >= maxLap)
            {
                finish = true;
                SaveLog.sw.Close();

                SceneManager.LoadScene("Result");
            }
        }
    }
}
