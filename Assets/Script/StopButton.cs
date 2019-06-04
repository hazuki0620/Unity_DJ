using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButton : MonoBehaviour {
	public AudioSource As;
	public void Onclick(){
		As.Pause ();
	}
}
