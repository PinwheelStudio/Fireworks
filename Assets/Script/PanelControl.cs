using UnityEngine;
using System.Collections;

public class PanelControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = hide;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowPanel()
	{
		if (transform.position == hide)
			transform.position = show;
		else 
			transform.position = hide;

	}

	Vector3 show = new Vector3 (13,13,0);
	Vector3 hide = new Vector3 (13,-130,0);
}
