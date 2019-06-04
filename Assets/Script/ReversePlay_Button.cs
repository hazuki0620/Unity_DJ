using UnityEngine;
using System.Collections;

public class ReversePlay_Button : MonoBehaviour
{
    public AudioSource audioSource;
    bool push = false;

    public void PushDown_2()
    {
        push = true;
    }

    public void PushUp_2()
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