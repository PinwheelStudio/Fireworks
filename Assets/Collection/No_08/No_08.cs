using UnityEngine;
using System.Collections;

public class No_08 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound");
		sound.GetComponent<AudioSource>().PlayDelayed (2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Launch(Vector3 direction)
	{
		GetComponent<Rigidbody>().velocity = direction * 1000 * Time.deltaTime;
		yield return new WaitForSeconds (4);
		Destroy (transform.gameObject);
	}

	Transform sound;
}
