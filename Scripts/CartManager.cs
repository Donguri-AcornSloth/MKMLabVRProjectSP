using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    private Vector2 stickL = new Vector2();
    public bool operation = false;

    public float roll { get; set; } = 0.0f;
    public float yaw { get; set; } = 0.0f;
    public float pitch { get; set; } = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        var audio = GetComponent<AudioSource>();

        if (OnOffSound.isSound == false)
        {
            audio.enabled = false;
        }
        else if (OnOffSound.isSound == true)
        {
            audio.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(stickL.x);
        stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

        if (operation)
        {
            this.transform.Rotate(0.0f, 0.0f, stickL.x);
        }
        else if(!operation)
        {
            this.transform.Rotate(roll, pitch, yaw);
        }
    }
}
