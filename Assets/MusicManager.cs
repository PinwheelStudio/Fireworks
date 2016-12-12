using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		music [0].PlayDelayed(3);
		music [1].PlayDelayed(205+3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public AudioSource[] music = new AudioSource[2];

}
