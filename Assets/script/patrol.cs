using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {


	public float StartTime=3f;
	private float WaitTime;
	public float speed=5f;

	public Transform movepoints;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;

	void Start () {
		WaitTime = StartTime;
		movepoints.position = new Vector2 (Random.Range(minX,maxX),Random.Range(minY,maxY));

	}
	
	// Update is called once per frame
	void Update () {
		
	
		transform.position=Vector2.MoveTowards (transform.position,movepoints.position,speed*Time.deltaTime);
		if (Vector2.Distance (transform.position,movepoints.position) < 0.2f) {
			

			if(WaitTime<=0){
				movepoints.position = new Vector2 (Random.Range(minX,maxX),Random.Range(minY,maxY));
				WaitTime = StartTime;
			}
			else{
				WaitTime-=Time.deltaTime;
			}
				
	}

	}


}
