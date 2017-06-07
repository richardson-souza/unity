using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityToggle : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable() {
		StartCoroutine (FadeIn(2f));
	}

	void OnDisable(){
		//StartCoroutine (FadeOut (2f));
	}

	IEnumerator FadeIn(float time){
		target.transform.localScale = Vector3.zero;
		target.gameObject.SetActive (true);
		float scale = 0;
		while (scale < 1) {
			yield return new WaitForFixedUpdate ();
			scale += Time.fixedDeltaTime / time;
			//transform.localScale = new Vector3 (scale, scale, scale);
			target.transform.localScale = Vector3.one * scale;
		}
	}

	IEnumerator FadeOut(float time){
		target.transform.localScale = Vector3.one;
		float scale = 1;
		while (scale > 0) {
			yield return new WaitForFixedUpdate ();
			scale -= Time.fixedDeltaTime / time;
			//transform.localScale = new Vector3 (scale, scale, scale);
			target.transform.localScale = Vector3.one * scale;
		}
		target.gameObject.SetActive (false);
	}

	public void ToggleVisibility() {
		//gameObject.SetActive (!gameObject.activeSelf);
		bool Active = target.gameObject.activeSelf;
		if (Active) {
			StartCoroutine(FadeOut(1f));
		}
		else{
			StartCoroutine(FadeIn(1f));
		}
	}
}
