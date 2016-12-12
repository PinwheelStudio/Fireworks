using UnityEngine;
using System.Collections;

public class No_06 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound");
		sound.GetComponent<AudioSource>().PlayDelayed (2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0.1f, 0.9f,0) * 25);
	}
	
	IEnumerator Launch(Vector3 direction)
	{
		GetComponent<Rigidbody>().velocity = direction * 1000 * Time.deltaTime;
		yield return new WaitForSeconds (5);
		Destroy (transform.gameObject);
	}
	
	Transform sound;


}
