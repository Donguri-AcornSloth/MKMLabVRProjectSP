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
        //���E�p�[�e�B�N�����Đ�
        AudioSource.PlayOneShot(ToStageSelectSE);
        SceneManager.LoadScene("StageSelection");
    }
}
