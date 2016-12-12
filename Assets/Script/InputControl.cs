using UnityEngine;
using System.Collections;

public class InputControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//No_00
		//From "1"-->"-"
		if (Input.GetKeyDown (KeyCode.Alpha6))
		{
			StartCoroutine(LaunchAlpha6 ());
		}

		if (Input.GetKeyDown (KeyCode.Alpha4))
		{
			StartCoroutine(LaunchAlpha4());
		}
		 
		if (Input.GetKeyDown (KeyCode.Alpha8))
		{
			StartCoroutine(LaunchAlpha8());
		}

		if (Input.GetKeyDown (KeyCode.Alpha3))
		{
			StartCoroutine(LaunchAlpha3());
		}

		if (Input.GetKeyDown (KeyCode.Alpha9))
		{
			StartCoroutine(LaunchAlpha9());
		}
		//end From "1"-->"-"

		//From "Q"-->"P"

		//end From "Q"-->"P"

		//No_01
		if (Input.GetKeyDown (KeyCode.Space))
		{
			tmp = Instantiate (No[12].gameObject,new Vector3(0,0,55),Quaternion.Euler(0,0,0)) as GameObject;

			tmp.SendMessage("Launch",Vector3.up);

		}

		//No_02

	}//end Update()

	IEnumerator LaunchAlpha6()
	{
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0, 1.2f, 0));

		yield return new WaitForSeconds (0.15f); 
		
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (0.4f, 0.96f, 0));
		
		tmp = Instantiate (No [00].gameObject, new Vector3 (0, 0, 55), Quaternion.identity) as GameObject;
		tmp.SendMessage ("Launch", new Vector3 (-0.4f, 0.96f, 0));

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.85f,0.85f,0));
		
		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.85f,0.85f,0));

		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (1,0.5f,0));

		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-1,0.5f,0));

		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-1,0.2f,0));

		tmp = Instantiate (No[00].gameObject,new Vector3(0,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (1,0.2f,0));
	}//end LaunchAlpha6()

	IEnumerator LaunchAlpha4()
	{

		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.4f, 1.15f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.7f, 0.9f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.9f, 0.6f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (1f, 0.3f,0)*1.1f);
	}//end LaunchAlpha4

	IEnumerator LaunchAlpha8()
	{
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.4f, 1.15f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.7f, 0.9f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.9f, 0.6f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-1f, 0.3f,0)*1.1f);
	}//end LaunchAlpha8

	IEnumerator LaunchAlpha3()
	{
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-1f, 0.3f,0)*1.1f);
	
		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.9f, 0.6f,0)*1.1f);
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.7f, 0.9f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (-0.4f, 1.15f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(-20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);
	}//end LaunchAlpha3

	IEnumerator LaunchAlpha9()
	{
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (1f, 0.3f,0)*1.1f);

		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.9f, 0.6f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.7f, 0.9f,0)*1.1f);
		
		yield return new WaitForSeconds (0.15f);

		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0.4f, 1.15f,0)*1.1f);
		yield return new WaitForSeconds (0.15f);
		
		tmp = Instantiate (No[00].gameObject,new Vector3(20,0,55),Quaternion.identity) as GameObject;
		tmp.SendMessage("Launch",new Vector3 (0, 1.3f,0)*1.1f);
	}//end LaunchAlpha9

	private GameObject tmp;
	//public Transform[] No = new Transform[20];
	public Transform [] No = new Transform[20];
	//GameObject tmp;
}
