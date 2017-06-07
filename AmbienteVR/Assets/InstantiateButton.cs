using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateButton : MonoBehaviour {
	public GameObject PrefabButton;
	public int Width, Height;
	public float PaddLeft, PaddDown;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < Width; i++) {
			for (int j = 0; j < Height; j++) {
				GameObject newButton = Instantiate (PrefabButton, gameObject.transform);
				newButton.transform.position = new Vector3 (PaddLeft * i, PaddDown * j, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
