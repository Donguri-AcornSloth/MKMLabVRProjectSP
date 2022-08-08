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
        
        //変数初期化
        LogData.score = 0;
        LogData.bulletCount = 0;
        LogData.movement = new Vector3(0, 0, 0);
        LogData.rotation = new Vector3(0, 0, 0);
        SaveLog.nowTime = 0;
        ToResult.finish = false;

        SaveLog.sw.Close();

        //ステージ読み込み
        SceneManager.LoadScene("StageSelection");
    }
}