using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStageSelect : MonoBehaviour
{
    public void OnClickButton()
    {
        SceneManager.LoadScene("StageSelection");
    }
}
