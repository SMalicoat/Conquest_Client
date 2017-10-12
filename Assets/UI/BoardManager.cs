using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	private  Vector3 tile_height = Vector3.forward*200;
	private  Vector3 tile_width = Vector3.right*200;
	private void DrawChessboard(){
		Vector3 s;
		for (int i = 0; i < 21; i++) {
			 s = Vector3.forward * i*10;
			Debug.DrawLine (s,s + tile_width);
			s = Vector3.right * i*10;
			//Debug.Log (height.x + ", " + height.y + ", " + height.z,null);
			Debug.DrawLine (s, s + tile_height);
		}
	}
	// Update is called once per frame
	void Update () {
		DrawChessboard ();
	}
}
