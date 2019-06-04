using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_play : MonoBehaviour
{
    public AudioSource audioSource;
    bool push = false;
    public void PushDown()
    {
        push = true;
    }

    public void PushUp()
    {
        push = false;
    }

    void Update()
    {
        if (push)
        {
            audioSource.pitch = -1.0f;
        }
        
    }
}