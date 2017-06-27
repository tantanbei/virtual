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

		glass = Resources.Load("GlassPrefab") as GameObject;
		singleSofa = Resources.Load ("SingleSofaPrefab") as GameObject;

		glass = Instantiate (glass);
		singleSofa = Instantiate (singleSofa);

		Hide (glass);
		Hide (singleSofa);
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (10, 10, 200, 200), "change model")) {
			if (i % 2 == 1) {
				Debug.Log ("Show glass");
				Show (glass);
				Hide (singleSofa);
			} else {
				Debug.Log ("Show singleSofa");
				Show (singleSofa);
				Hide (glass);
			}
			i++;
		}
	}

	void Show(GameObject game)
	{
		Renderer[] lChildRenderers=game.GetComponentsInChildren<Renderer>();
		foreach ( Renderer lRenderer in lChildRenderers)
		{
			lRenderer.enabled=true;
		}
	}

	void Hide(GameObject game)
	{
		Renderer[] lChildRenderers=game.GetComponentsInChildren<Renderer>();
		foreach ( Renderer lRenderer in lChildRenderers)
		{
			lRenderer.enabled=false;
		}
	}
}