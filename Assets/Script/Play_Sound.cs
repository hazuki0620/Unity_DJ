using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Sound : MonoBehaviour {
	public AudioClip[] audioClip;
	private AudioSource audioSource;
	int k=0;
	void update () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip [0];
		if (Input.GetKeyDown (KeyCode.K)) {
			k += 1;
			if (k >= audioClip.Length - 1) {
				k = audioClip.Length - 1;
			}
			print (k);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			k=k-1;
			if (k <= 0) {
				k = 0;
			}
			print (k);
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			audioSource.clip = audioClip [2];
			audioSource.Play ();
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			audioSource.Stop ();
		}
	}
}
