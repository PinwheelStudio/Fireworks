using UnityEngine;
using System.Collections;

public class Layer_00 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Launch()
	{
		yield return new WaitForSeconds (3 + 0.1f);
	
		//sec 0
		tmp = Instantiate (No [07].gameObject, new Vector3 (30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
	
		tmp = Instantiate (No [07].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (-10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (-30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		//sec 2
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.67f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler(0,0,-25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler(0,0,25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.67f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,-5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.3f);

		//sec 4
		tmp = Instantiate (No [07].gameObject, new Vector3 (-30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (-10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (10, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (30, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.285f);
		
		//sec 6
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,-5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.67f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler(0,0,-25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler(0,0,25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.67f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);

		//sec 7.x
		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.97f, 0.29f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.97f, 0.29f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.88f, 0.56f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.88f, 0.56f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.65f, 0.67f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.65f, 0.67f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.45f, 0.9f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.45f, 0.9f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.15f, 0.98f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.15f, 0.98f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.15f, 0.98f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.15f, 0.98f, 0));

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.45f, 0.9f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (20, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.45f, 0.9f, 0));

		yield return new WaitForSeconds (0.4f);

		//sec 10
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1, 0));
		
		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.32f, 0.95f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.32f, 0.95f, 0));
		
		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 0.83f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 0.83f, 0));
		
		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.84f, 0.6f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.84f, 0.6f, 0));
		
		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.95f, 0.3f, 0));
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 50), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.95f, 0.3f, 0));
		
		yield return new WaitForSeconds (0.285f);

		//sec 11.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,60)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,-60)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (16, 0, 50), Quaternion.Euler(0,0,45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-16, 0, 50), Quaternion.Euler(0,0,-45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (12, 0, 50), Quaternion.Euler(0,0,30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-12, 0, 50), Quaternion.Euler(0,0,-30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (8, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-8, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.285f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (4, 0, 50), Quaternion.Euler(0,0,5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-4, 0, 50), Quaternion.Euler(0,0,-5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (3);

		//sec 15.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-40)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,40)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,-20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-40)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,40)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (1);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,-10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (1);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler(0,0,20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler(0,0,-20)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (2);

		//sec 23.x

		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler(0,0,0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		tmp = Instantiate (No [07].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler(0,0,0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		tmp = Instantiate (No [07].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler(0,0,-15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (2);

		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.4f, 1.15f,0)*1.1f);
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.4f, 1.15f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.7f, 0.9f,0)*1.1f);
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.7f, 0.9f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.9f, 0.6f,0)*1.1f);
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.9f, 0.6f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (1f, 0.3f,0)*1.1f);
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-1f, 0.3f,0)*1.1f);

		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [08].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up);
		tmp = Instantiate (No [08].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage("Launch", Vector3.up);

		yield return new WaitForSeconds (1f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (3f);

		//sec 33.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 15)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -15)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 25)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -25)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 35)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -35)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 55)) as GameObject;
		tmp.SendMessage("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -55)) as GameObject;
		tmp.SendMessage("ThenDestroy");

		//sec 37.x
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.13f, 0.88f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.25f, 0.93f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 0.88f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.45f, 0.77f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.3f, 0.68f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.14f, 0.74f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0f, 0.8f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.27f, 0.92f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.62f, 0.86f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 0.76f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.55f, 0.69f, 0));
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.15f, 0.73f, 0));

		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.13f, 0.88f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.25f, 0.93f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.6f, 0.88f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.45f, 0.77f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.3f, 0.68f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.14f, 0.74f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0f, 0.8f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.27f, 0.92f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.62f, 0.86f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.6f, 0.76f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.55f, 0.69f, 0)*1.35f);
		yield return new WaitForSeconds (0.05f);
		tmp = Instantiate (No [06].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.15f, 0.73f, 0)*1.35f);

		yield return new WaitForSeconds (1);

		//sec 38.x
		tmp = Instantiate (No [11].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [11].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (1);

		tmp = Instantiate (No [11].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [11].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [11].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (1f);
		//sec 44.x
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -33.75f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [07].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -11.25f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 22.5f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -22.5f)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (3.5f);

		//sec 49.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (15, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (25, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (35, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-15, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-25, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-35, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (15, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (25, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (35, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-15, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-25, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-35, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (2f);

		//sec 53.x
		tmp = Instantiate (No [00].gameObject, new Vector3 (-5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);

		tmp = Instantiate (No [00].gameObject, new Vector3 (-5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-2.5f, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);
		yield return new WaitForSeconds(0.1f);
		tmp = Instantiate (No [00].gameObject, new Vector3 (-5, 0, 55), Quaternion.Euler (0, 0, 0)) as GameObject;
		tmp.SendMessage ("Launch", Vector3.up);

		yield return new WaitForSeconds(2f);

		//sec 56.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 50), Quaternion.Euler (-30, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		yield return new WaitForSeconds (0.1f);
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 50), Quaternion.Euler (-45, 0, 0)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (1f);

		//sec 60.x
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);

		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (2.5f);

		//sec 1:04
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (15, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (25, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (35, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, -10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-15, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-25, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-35, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 10)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (10, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (15, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (20, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (25, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (30, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (35, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (40, 0, 55), Quaternion.Euler (0, 0, -30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		
		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (-10, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-15, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-20, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-25, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-30, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-35, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (-40, 0, 55), Quaternion.Euler (0, 0, 30)) as GameObject;
		tmp.SendMessage ("ThenDestroy");

		yield return new WaitForSeconds (0.5f);
		
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, -5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 45)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 35)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 25)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 15)) as GameObject;
		tmp.SendMessage ("ThenDestroy");
		tmp = Instantiate (No [09].gameObject, new Vector3 (0, 0, 50), Quaternion.Euler (0, 0, 5)) as GameObject;
		tmp.SendMessage ("ThenDestroy");


	}

	GameObject tmp;
	public Transform[] No = new Transform[20];
}
