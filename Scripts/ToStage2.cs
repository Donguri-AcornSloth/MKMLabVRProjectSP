using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStage2 : MonoBehaviour
{
    public void OnClickButton()
    {
        SceneManager.LoadScene("Stage2");
    }
}