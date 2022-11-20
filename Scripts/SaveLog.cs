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

    // éûä‘ópïœêî
    public static float nowTime = 0f;

    public static bool update = true;

    // Start is called before the first frame update
    void Start()
    {
        update = true;
        DateTime now = DateTime.Now;
        sw = new StreamWriter(@"SaveData_" + now.Year.ToString() + "_" + now.Month.ToString() + "_" + now.Day.ToString() + "_" + now.Hour.ToString() + "_" + now.Minute.ToString() + ".csv", false, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "Time", "Score", "BulletCount", "Movement.x", "Movement.y", "Movement.z", "Rotation.x", "Rotation.y", "Rotation.z" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        if(update == true)
        {
            nowTime += Time.deltaTime;
            SaveCSVLog(LogData.score, LogData.bulletCount, LogData.movement, LogData.rotation);
        }

        if(ToResult.finish == true)
        {
            sw.Close();
        }
    }

    public void SaveCSVLog(int score, int bulletCount, Vector3 movement, Vector3 rotation)
    {
        int minute = (int)nowTime / 60;
        int second = (int)nowTime % 60;
        String timeText = minute.ToString() + ":" + second.ToString();
        string[] s1 = { timeText, score.ToString(), bulletCount.ToString(), movement.x.ToString("0000"), movement.y.ToString("0000"), movement.z.ToString("0000"), rotation.x.ToString("0000"), rotation.y.ToString("0000"), rotation.z.ToString("0000") };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }
}
