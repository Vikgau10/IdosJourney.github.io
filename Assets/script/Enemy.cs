using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
	
 public float RotationSpeed=30f;
 public float Distance=5f;
 public LineRenderer line;
 public Gradient redcolor;
 public Gradient greencolor;

	public void Start(){

		Physics2D.queriesStartInColliders = false;

	}

	void Update () {
		
		transform.Rotate (Vector3.forward, RotationSpeed * Time.deltaTime);
		RaycastHit2D ray = Physics2D.Raycast (transform.position,transform.right,Distance);

		if (ray.collider != null) {
			line.SetPosition (1, ray.point);
			line.colorGradient = redcolor;
			if (ray.collider.CompareTag ("Player")) {
				Destroy (ray.collider.gameObject);

				SceneManager.LoadScene (8);
			}

		} else {
			
			line.SetPosition (1,transform.position+transform.right*Distance);
			line.colorGradient = greencolor;
		}

		line.SetPosition (0, transform.position);
	}
}
