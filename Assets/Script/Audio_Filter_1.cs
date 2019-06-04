using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Filter_1 : MonoBehaviour {
	public AudioSource As;
	public AudioHighPassFilter Ah;
	private Slider slider;
	float k;
	void Start(){
		slider = GetComponent<Slider> ();
		slider.value = 0;
	}
	void Update () {
		k = slider.value;
		Ah.cutoffFrequency = k;
	}
	public void MoveSlider(){
	}
}
