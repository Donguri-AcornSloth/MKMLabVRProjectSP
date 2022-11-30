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
    public static bool update = true;
    private string fileName;

    // éûä‘ópïœêî
    public static float nowTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        update = true;
        DateTime now = DateTime.Now;
        fileName = "SaveData_" + now.Year.ToString() + "_" + now.Month.ToString() + "_" + now.Day.ToString() + "_" + now.Hour.ToString() + "_" + now.Minute.ToString() + ".csv";
        sw = new StreamWriter(fileName, false, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "Time", "Score", "BulletCount", "Movement.x", "Movement.y", "Movement.z", "Rotation.x", "Rotation.y", "Rotation.z"};
        string s2 = string.Join(",", s1);

        string path = Application.dataPath + "/" + fileName;
        FileInfo fi = new FileInfo(path);
        using (sw = fi.AppendText())
        {
            sw.WriteLine(s2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(update == true)
        {
            nowTime += Time.deltaTime;
            SaveCSVLog(sw, LogData.score, LogData.bulletCount, LogData.movement, LogData.rotation, fileName);
        }

        if(ToResult.finish == true)
        {
            sw.Close();
        }
    }

    public void SaveCSVLog(StreamWriter sw, int score, int bulletCount, Vector3 movement, Vector3 rotation, string fileName)
    {
        int minute = (int)nowTime / 60;
        int second = (int)nowTime % 60;
        string timeText = minute.ToString() + ":" + second.ToString();
        string[] s1 = { timeText, score.ToString(), bulletCount.ToString(), movement.x.ToString("0000"), movement.y.ToString("0000"), movement.z.ToString("0000"), rotation.x.ToString("0000"), rotation.y.ToString("0000"), rotation.z.ToString("0000") };
        string s2 = string.Join(",", s1);

        string path = Application.dataPath + "/" + fileName;
        FileInfo fi = new FileInfo(path);
        using (sw = fi.AppendText())
        {
            sw.WriteLine(s2);
        }
            //sw.WriteLine(s2);
    }
}
