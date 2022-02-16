using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartAnimation : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("shakeBool", false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "shake")
        {
           
            anim.SetBool("shakeBool", true);
        }

        if (other.gameObject.tag == "stopShake")
        {
            //Debug.Log(script.m_Speed);
            anim.SetBool("shakeBool", false);
        }

        if (other.gameObject.tag == "rotate")
        {
            Debug.Log("a");
            anim.SetTrigger("rotateTrigger");
        }

      
    }
}
