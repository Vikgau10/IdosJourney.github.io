using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	private Transform key;
	private Transform coin;
	private int speed=4;


	public void Start(){

		key = GameObject.FindGameObjectWithTag ("key").GetComponent<Transform> ();
		coin = GameObject.FindGameObjectWithTag ("coin").GetComponent<Transform> ();
		coin.Rotate (new Vector3(0f,0f,-2f));
		key.Rotate (Vector2.right*speed*Time.deltaTime);

	}
	

	void Update () {
		transform.Rotate (new Vector3(0f,0f,-5f));
	
	}
}
