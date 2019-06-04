using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EQ : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float Frequency_1 {
		set{ mixer.SetFloat ("Song1_Freq_1", Mathf.Lerp (0, 2, value)); }
	}
}