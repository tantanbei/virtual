using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefbe : MonoBehaviour {

	public string url;
	void Start () {
		GameObject abc = Resources.Load("glass") as GameObject;

		abc = Instantiate (abc);
 
		GameObject mUICanvas = GameObject.Find("ImageTaget");  
		abc.transform.parent = mUICanvas.transform;  
	}

	void Update () {

	}    
}
