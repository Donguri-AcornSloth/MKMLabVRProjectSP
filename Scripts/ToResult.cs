using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToResult : MonoBehaviour
{
    public void OnClickButton()
    {
        SceneManager.LoadScene("Result");
    }
}
