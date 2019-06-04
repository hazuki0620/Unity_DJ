using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Song_Change : MonoBehaviour {
	public AudioSource AS_1;
	public AudioSource AS_2;
	public Slider Slider_1;
	float k;
	void Start(){
		Slider_1 = GetComponent<Slider> ();
		k = Slider_1.value;
	}
	public void MoveSlider(){
		k = Slider_1.value;
		Debug.Log (k);
		AS_1.volume = 1.0f-k;
		AS_2.volume = k;
		
	}

}
