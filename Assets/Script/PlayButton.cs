using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {
	public AudioSource As;
	public void Onclick(){
		As.Play ();
	}
}
