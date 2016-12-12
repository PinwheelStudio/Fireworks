using UnityEngine;
using System.Collections;

public class No_03 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound_00");
		sound.GetComponent<AudioSource>().PlayDelayed (2.2f);
		sound = transform.Find ("Sound_01");
		sound.GetComponent<AudioSource>().PlayDelayed (4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 25);
	}

	IEnumerator Launch(Vector3 direction)
	{
		GetComponent<Rigidbody>().velocity = direction * 1000 * Time.deltaTime;
		yield return new WaitForSeconds (8f);
		Destroy (transform.gameObject);
		
	}

	Transform sound;
}
