using UnityEngine;
using System.Collections;

public class No_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound_00");
		sound.GetComponent<AudioSource>().volume = 0.5f;
		sound.GetComponent<AudioSource>().PlayDelayed (2.2f);

		sound = transform.Find ("Sound_01");
		sound.GetComponent<AudioSource>().volume = 0.3f;
		sound.GetComponent<AudioSource>().PlayDelayed (2.7f);

		sound = transform.Find ("Sound_02");
		sound.GetComponent<AudioSource>().volume = 0.3f;
		sound.GetComponent<AudioSource>().PlayDelayed (3.2f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 25);
	}

	IEnumerator Launch(Vector3 direction)
	{
		GetComponent<Rigidbody>().velocity = direction * 800 * Time.deltaTime;
		yield return new WaitForSeconds (5);
		Destroy (transform.gameObject);

	}

	Transform sound;
}
