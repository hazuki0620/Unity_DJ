using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setVolume_2 : MonoBehaviour {
	[SerializeField]
	UnityEngine.Audio.AudioMixer mixer2;
	public float masterVolume {
		set{ mixer2.SetFloat ("Song_2_Volume", Mathf.Lerp (-80, 0, value)); }
	}
}
