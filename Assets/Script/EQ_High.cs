﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EQ_High : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float Frequency_2 {
		set{ mixer.SetFloat ("Song1_Freq_2", Mathf.Lerp (0, 2, value)); }
	}
}
