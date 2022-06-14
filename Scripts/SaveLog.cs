using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class SaveLog : MonoBehaviour
{
    private StreamWriter sw;

    // Start is called before the first frame update
    void Start()
    {
        sw = new StreamWriter(@"SaveData.csv", false, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "Score", "BulletCount", "Movement.x", "Movement.y", "Movement.z", "Rotation.x", "Rotation.y", "Rotation.z" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveCSVLog(int score, int bulletCount, Vector3 movement, Vector3 rotation)
    {
        string[] s1 = { score.ToString(), bulletCount.ToString(), movement.x.ToString("0000"), movement.y.ToString("0000"), movement.z.ToString("0000"), rotation.x.ToString("0000"), rotation.y.ToString("0000"), rotation.z.ToString("0000") };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
        //sw.WriteLine(LogData.score.ToString(), LogData.bulletCount.ToString(), LogData.movement.ToString("0000"), LogData.rotation.ToString("0000"));
        //sw.Flush();
    }

    public void CSVClose()
    {
        sw.Close();
    }
}
