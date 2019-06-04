using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolume : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer;
	public float masterVolume {
		set{ mixer.SetFloat ("Song_1_Volume", Mathf.Lerp (-80, 0, value)); }
	}
}