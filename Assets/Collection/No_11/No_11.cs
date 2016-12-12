using UnityEngine;
using System.Collections;

public class No_11 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator ThenDestroy()
	{
		//rigidbody.velocity = direction * 1500 * Time.deltaTime;
		yield return new WaitForSeconds (3f);
		Destroy (transform.gameObject);	
	}


}
