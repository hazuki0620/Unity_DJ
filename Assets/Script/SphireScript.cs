using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphireScript : MonoBehaviour {

    public GameObject par;
    private void Start()
    {
        Destroy(this.gameObject, 10.0f);
    }
    void Update () {
        this.transform.position += new Vector3(-8 * Time.deltaTime, 0, 0);
	}
    private void OnCollisionEnter(Collision collision)
    {
        //par.SetActive(true);
        //Invoke("Delay", 0.5f);
        //Destroy(this.gameObject);
    }
    void Delay()
    {
        par.SetActive(false);
    }
}
