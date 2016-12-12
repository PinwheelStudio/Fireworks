using UnityEngine;
using System.Collections;

public class No_00 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator Launch(Vector3 direction)
	{
		GetComponent<Rigidbody>().velocity = direction * 1500 * Time.deltaTime;
		yield return new WaitForSeconds (1.2f);
		Destroy (transform.gameObject);


	}
}
