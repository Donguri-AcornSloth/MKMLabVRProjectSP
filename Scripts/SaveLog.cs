using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class SaveLog : MonoBehaviour
{
    // CSVópïœêî
    public static StreamWriter sw;
    DateTime dt;

    // éûä‘ópïœêî
    public static float nowTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        dt = DateTime.Now;
        //sw = new StreamWriter("LogData_" + dt.Year.ToString() + "_" + dt.Month.ToString() + "_" + dt.Day.ToString() + "_" + dt.Hour.ToString() + "_" + dt.Minute.ToString() + ".csv", false, Encoding.GetEncoding("Shift_JIS"));
        //string[] s1 = { "Time", "Score", "BulletCount", "Movement.x", "Movement.y", "Movement.z", "Rotation.x", "Rotation.y", "Rotation.z" };
        //string s2 = string.Join(",", s1);
        //sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        SaveCSVLog(LogData.score, LogData.bulletCount, LogData.movement, LogData.rotation, sw);

        if (ToResult.finish == true)
        {
            //CSVClose();
        }
    }

    public void SaveCSVLog(int score, int bulletCount, Vector3 movement, Vector3 rotation, StreamWriter sw)
    {
        int minute = (int)nowTime / 60;
        int second = (int)nowTime % 60;
        String timeText = minute.ToString() + ":" + second.ToString();
        string[] s1 = { timeText, score.ToString(), bulletCount.ToString(), movement.x.ToString("0000"), movement.y.ToString("0000"), movement.z.ToString("0000"), rotation.x.ToString("0000"), rotation.y.ToString("0000"), rotation.z.ToString("0000") };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    public void CSVClose(StreamWriter sw)
    {
        sw.Close();
    }
}
