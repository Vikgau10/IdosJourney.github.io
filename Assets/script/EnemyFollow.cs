using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public Transform player;
	public float speed=3f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();

	}
	

	void Update () {

		if(Vector2.Distance(transform.position,player.position)<2){
			transform.position=Vector2.MoveTowards (transform.position,player.position,speed*Time.deltaTime);
		
	}
		else if(Vector2.Distance(transform.position,player.position)>3){
			transform.position = this.transform.position;
	
			}


}



}
