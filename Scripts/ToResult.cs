using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToResult : MonoBehaviour
{
    // ���񐔊֘A�̕ϐ�
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
            // ���񐔂��J�E���g
            lapCount++;

            if (lapCount >= maxLap)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
