using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContlloer : MonoBehaviour {
	void Update () {
		var x = Input.GetAxis ("Horizontal")*Time.deltaTime*50.0f;
		var z = Input.GetAxis ("Vertical")*Time.deltaTime*10.0f;
		transform.Translate (0, 0, z);
		transform.Rotate (0, x, 0);
	}
}
