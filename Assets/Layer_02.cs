using UnityEngine;
using System.Collections;

public class Layer_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Launch()
	{
		yield return new WaitForSeconds (3 + 12.5f);
		//sec 12.x
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch",Vector3.up*multiplier);
		
		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [04].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch",new Vector3 (-0.6f,0.8f,0)*multiplier);
		tmp = Instantiate (No [04].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.5f, 0.7f, 0)*multiplier);

		yield return new WaitForSeconds (2.5f);

		tmp = Instantiate (No [08].gameObject, new Vector3 (10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		tmp = Instantiate (No [08].gameObject, new Vector3 (30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		tmp = Instantiate (No [08].gameObject, new Vector3 (-10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		tmp = Instantiate (No [08].gameObject, new Vector3 (-30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);

		yield return new WaitForSeconds (2.5f);

		tmp = Instantiate (No [04].gameObject, new Vector3 (-30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);
		tmp = Instantiate (No [04].gameObject, new Vector3 (30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);

		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [03].gameObject, new Vector3 (10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);
		tmp = Instantiate (No [03].gameObject, new Vector3 (-10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);

		yield return new WaitForSeconds (1f);

		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 0.6f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.26f, 0.65f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.26f, 0.65f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.33f, 0.82f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.33f, 0.82f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 0.93f, 0));
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 0.93f, 0));

		yield return new WaitForSeconds (2);

		//sec 23
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 0.9f, 0)*multiplier);

		yield return new WaitForSeconds (0.3f);

		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.65f, 1, 0)*multiplier);

		yield return new WaitForSeconds (0.3f);

		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.7f, 0.7f, 0)*multiplier);

		yield return new WaitForSeconds (3f);
		
		tmp = Instantiate (No [02].gameObject, new Vector3 (-15, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);
		tmp = Instantiate (No [02].gameObject, new Vector3 (15, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up*multiplier);

		yield return new WaitForSeconds (3f);

		tmp = Instantiate (No [04].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 0.8f, 0)*multiplier);
		
		tmp = Instantiate (No [04].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 1, 0)*multiplier);
		
		tmp = Instantiate (No [04].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 1f, 0)*multiplier);

		yield return new WaitForSeconds (6f);

		tmp = Instantiate (No [08].gameObject, new Vector3 (-10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.5f, 1f, 0));
		tmp = Instantiate (No [08].gameObject, new Vector3 (-30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.5f, 1f, 0));

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [08].gameObject, new Vector3 (10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.5f, 1f, 0));
		tmp = Instantiate (No [08].gameObject, new Vector3 (30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.5f, 1f, 0));
		
		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [10].gameObject, new Vector3 (5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", new Vector3 (0.4f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [10].gameObject, new Vector3 (-5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", new Vector3 (-0.4f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up*multiplier);

		yield return new WaitForSeconds (3);

		//sec 40.x
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up*multiplier);
		yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.8f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.8f, 0.9f, 0)*multiplier);
		yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.4f, 0.7f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.4f, 0.7f, 0)*multiplier);

		yield return new WaitForSeconds (2);

		//sec 42.x
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up*multiplier);
		//yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.4f, 0.7f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.4f, 0.7f, 0)*multiplier);
		//yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.8f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.8f, 0.9f, 0)*multiplier);

		yield return new WaitForSeconds (4.5f);

		tmp = Instantiate (No [10].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1f, 0)*multiplier);

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [02].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1, 0)*multiplier);
		tmp = Instantiate (No [02].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1, 0)*multiplier);

		yield return new WaitForSeconds (2.5f);

		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.3f, 1, 0)*multiplier);
		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.3f, 1, 0)*multiplier);

		yield return new WaitForSeconds (6.5f);

		//sec 54.x
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1f, 0)*multiplier);
		yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [05].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 1, 0)*multiplier);
		tmp = Instantiate (No [05].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 1, 0)*multiplier);
		yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [05].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (1.2f, 0.8f, 0)*multiplier);
		tmp = Instantiate (No [05].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-1.2f, 0.8f, 0)*multiplier);

		yield return new WaitForSeconds (4f);

		//sec 1:00
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.4f, 0.7f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.4f, 0.7f, 0)*multiplier);
		yield return new WaitForSeconds (0.5f);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.8f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [01].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.8f, 0.9f, 0)*multiplier);

		yield return new WaitForSeconds (5f);

		//sec 1:04
		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up*multiplier);
		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.8f, 0.9f, 0)*multiplier);
		tmp = Instantiate (No [03].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.8f, 0.9f, 0)*multiplier);

		yield return new WaitForSeconds (5);
		tmp = Instantiate (No [12].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up*multiplier);


	}

	float multiplier = 2f;
	GameObject tmp;
	public Transform[] No = new Transform[20];
}
