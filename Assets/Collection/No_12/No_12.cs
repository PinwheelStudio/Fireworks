using UnityEngine;
using System.Collections;

public class No_12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sound = transform.Find ("Sound");
		sound.GetComponent<AudioSource>().PlayDelayed (5f);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		transform.Rotate (Vector3.up * 10);
		//			if (Input.GetKeyDown (KeyCode.Space))
		//						StartCoroutine (Launch());
	}
	
	IEnumerator Launch(Vector3 direction)
	{
		
		GetComponent<Rigidbody>().velocity = direction * 500 * Time.deltaTime;
		yield return new WaitForSeconds (10f);
		Destroy (transform.gameObject);
	}
	
	Transform sound;
}
