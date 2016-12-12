using UnityEngine;
using System.Collections;

public class PlayMusicAndLaunch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}
	}

	void OnTriggerEnter(Collider trigInfo)
	{
		tmp = transform.Find ("Layer_00");
		tmp.SendMessage ("Launch");

		tmp = transform.Find ("Layer_01");
		tmp.SendMessage ("Launch");

		tmp = transform.Find ("Layer_02");
		tmp.SendMessage ("Launch");
	}

	Transform tmp;

}
