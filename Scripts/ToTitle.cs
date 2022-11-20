using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour
{
    public AudioClip ToTitleSE;
    private AudioSource AudioSource;

    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClickButton();
        }
    }

    public void OnClickButton()
    {
        //���E�p�[�e�B�N�����Đ�
        AudioSource.PlayOneShot(ToTitleSE);
        SceneManager.LoadScene("TitleScene");
    }
}
