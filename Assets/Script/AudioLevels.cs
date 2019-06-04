using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLevels : MonoBehaviour {
	public AudioSpectrum spectrum;
	public float[] num;
	public float scale;

	private void Update()
	{
		for (int i = 0; i < num.Length; i++) {
			num[i] = spectrum.Levels [i] * scale;
			if (i == 0) {
				GetComponent<Renderer> ().material.SetFloat ("_Size0", num[i]);
			}
			if (i == 1) {
				GetComponent<Renderer> ().material.SetFloat ("_Size1", num[i]);
			}
			if (i == 2) {
				GetComponent<Renderer> ().material.SetFloat ("_Size2", num[i]);
			}
			if (i == 3) {
				GetComponent<Renderer> ().material.SetFloat ("_Size3", num[i]);
			}

		}
	}
}
