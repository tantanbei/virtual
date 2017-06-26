using UnityEngine;
using System.Collections.Generic;

public class VirtualHandler : MonoBehaviour
{
	GameObject mUICanvas;
	GameObject glass;
	GameObject singleSofa;
	int i = 0;

	/// Called when the scene is loaded
	void Start ()
	{
		mUICanvas = GameObject.Find("ImageTaget");

		glass = Resources.Load("glass") as GameObject;
		singleSofa = Resources.Load ("singleSofa") as GameObject;
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (10, 10, 200, 200), "change model")) {
			if (i % 2 == 1) {
				Debug.Log ("Show glass");
				glass = Instantiate (glass);
				glass.GetComponent<Renderer> ().enabled = true;
//				glass.transform.parent = mUICanvas.transform;
				Renderer[] lChildRenderers=singleSofa.GetComponentsInChildren<Renderer>();
				foreach ( Renderer lRenderer in lChildRenderers)
				{
					lRenderer.enabled=false;
				}
			} else {
				Debug.Log ("Show singleSofa");
				singleSofa = Instantiate (singleSofa);
//				singleSofa.transform.parent = mUICanvas.transform;

				Renderer[] lChildRenderers=singleSofa.GetComponentsInChildren<Renderer>();
				foreach ( Renderer lRenderer in lChildRenderers)
				{
					lRenderer.enabled=true;
				}

				glass.GetComponent<Renderer> ().enabled = false;
			}
			i++;
		}
	}
}