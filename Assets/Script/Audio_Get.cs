using UnityEngine;
using System.Collections;

public class Audio_Get : MonoBehaviour
{
	public GameObject cube2;
	public int numberOfObjects = 2 * 2 * 2 * 2 * 2 * 2;

	float[] samples = new float[2048];

	public GameObject[] lines;

	void Start ()
	{
		lines = new GameObject[2048];
		for (int i = 0; i < 2048; i++) {
			Vector3 pos = new Vector3 (0.1f * i - 15f, 0f, 10f);
			var obj = Instantiate (cube2, pos, Quaternion.identity) as GameObject;
			lines [i] = obj;
		}
	}

	void Update ()
	{
		AudioListener.GetSpectrumData (samples, 0, FFTWindow.BlackmanHarris);

		// show lines
		for (int i = 0; i < 2048; i++) {
			Vector3 s = lines [i].transform.localScale;
			//s.y = Mathf.Lerp (s.y, samples [i] * 200, Time.deltaTime * 30);
			s.y = samples [i] * 200;
			lines [i].transform.localScale = s;
		}

	}
}