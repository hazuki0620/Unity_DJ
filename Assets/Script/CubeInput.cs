using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInput : MonoBehaviour {
    public GameObject cube;
    private float tmp=0;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
        tmp += Time.deltaTime;
        if (tmp >= 2.0f)
        {
            Instantiate(cube,new Vector3(0.0f,3.0f,0.0f),Quaternion.identity);
            tmp = 0;
        }
	}

}
