using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EQ_Mid_2 : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float Frequency_2 {
		set{ mixer.SetFloat ("Song2_Freq_1", Mathf.Lerp (0, 2, value)); }
	}
}