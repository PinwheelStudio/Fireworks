using UnityEngine;
using System.Collections;

public class No_01: MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound");
		sound.GetComponent<AudioSource>().PlayDelayed (2.5f);
	}
	
	// Update is called once per frame
	void Update () 
	{	
			transform.Rotate (Vector3.up * 25);
//			if (Input.GetKeyDown (KeyCode.Space))
//						StartCoroutine (Launch());
	}

	IEnumerator Launch(Vector3 direction)
	{

		GetComponent<Rigidbody>().velocity = direction * 1000 * Time.deltaTime;
		yield return new WaitForSeconds (5f);
		Destroy (transform.gameObject);
	}

	Transform sound;
}
