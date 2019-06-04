using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EQ_Low_2 : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float Frequency_2 {
		set{ mixer.SetFloat ("Song2_Freq_3", Mathf.Lerp (0, 2, value)); }
	}
}
