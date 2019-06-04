using UnityEngine;
using System.Collections;

public class FastForward : MonoBehaviour
{
    public AudioSource audioSource;

    int push = 0;

    public void PushDown_1()
    {
        audioSource.pitch = -1.0f;
    }
    public void PushUp_1()
    {
        audioSource.pitch = 1.0f;
    }
    public void PushDown_2()
    {
        audioSource.pitch = 2.0f;
    }
    public void PushUp_2()
    {
        audioSource.pitch = 1.0f;
    }
}
