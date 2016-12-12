using UnityEngine;
using System.Collections;

public class No_07 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//sound = transform.Find ("Sound");
		//sound.audio.PlayDelayed (2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 25);
	}

	IEnumerator ThenDestroy()
	{
		//rigidbody.velocity = direction * 800 * Time.deltaTime;
		yield return new WaitForSeconds (4);
		Destroy (transform.gameObject);
	}
	
	//Transform sound;
}
