using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EQ_Low : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float Frequency_3 {
		set{ mixer.SetFloat ("Song1_Freq_3", Mathf.Lerp (0, 2, value)); }
	}
}
