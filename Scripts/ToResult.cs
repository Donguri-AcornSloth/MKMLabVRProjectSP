using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToResult : MonoBehaviour
{
    // 周回数関連の変数
    public int lapCount;
    public int maxLap = 3;

    public void OnClickButton()
    {
        SceneManager.LoadScene("Result");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // 周回数をカウント
            lapCount++;

            if (lapCount >= maxLap)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
