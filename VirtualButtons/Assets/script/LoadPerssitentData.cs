using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPerssitentData : MonoBehaviour {

	public string url;
	void Start () {
		IEnumerator abc = LoadMainGameObject("file://" + Application.persistentDataPath + "/abc.assetbundle");
		StartCoroutine (abc);

		//GameObject mUICanvas = GameObject.Find("ImageTaget");  
		//abc.transform.parent = mUICanvas.transform;  
	}

	void Update () {

	}    

	private IEnumerator LoadMainGameObject(string path){
		Debug.Log("+++++++++++++++++++++++++++Load "+path);
		WWW bundle = new WWW(path);
		yield return bundle;
		//加载到游戏中
		yield return Instantiate(bundle.assetBundle.mainAsset);
		Debug.Log("+++++++++++++++++++++++++++Load successful!!");
		bundle.assetBundle.Unload(false);
	}
}
