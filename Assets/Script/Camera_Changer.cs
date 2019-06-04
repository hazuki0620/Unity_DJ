using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Changer : MonoBehaviour {
    public GameObject camera_1;
    public GameObject camera_2;
    public GameObject camera_3;
    public GameObject Cube_1;
    public Material[] material;
    public void Onclick_1 () {
        Cube_1.GetComponent<Renderer>().material = this.material[0];
        camera_1.SetActive(true);
        camera_2.SetActive(false);
        camera_3.SetActive(false);
    }
    public void Onclick_2()
    {
        Cube_1.GetComponent<Renderer>().material = this.material[1];
        camera_1.SetActive(false);
        camera_2.SetActive(true);
        camera_3.SetActive(false);
    }
    public void Onclick_3()
    {
        Cube_1.GetComponent<Renderer>().material = this.material[2];
        camera_1.SetActive(false);
        camera_2.SetActive(false);
        camera_3.SetActive(true);
    }

}
