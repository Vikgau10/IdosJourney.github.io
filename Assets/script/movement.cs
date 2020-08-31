using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed=10f;
	public Text t;
	public static int coins = 0;
	private int key=0;
	private SpriteRenderer sp;
	private int nextscene;
	public Text t1;
	public int HighScore;
	public Text t3;




	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sp = GetComponent<SpriteRenderer> ();
		nextscene = SceneManager.GetActiveScene ().buildIndex+1;
		HighScore = coins;


	}
	
	// Update is called once per frame
	void Update () {

		Score ();
		Scene ();
		move ();


	}

	public void move(){
		
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
			sp.flipX = true;

		} else if (Input.GetKey (KeyCode.A)) {
			
			transform.Translate (Vector2.left * speed * Time.deltaTime);
			sp.flipX = false;

		} else if (Input.GetKey (KeyCode.W)) {

			transform.Translate (Vector2.up * speed * Time.deltaTime);

		} else if (Input.GetKey (KeyCode.S)) {

			transform.Translate (Vector2.down * speed * Time.deltaTime);

		}
}

	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag ("coin")) {
			coins += 1;
			Destroy (col.gameObject);
			t.text ="Coins:"+coins.ToString ();
		
		} 

		else if (col.gameObject.CompareTag ("key")) {

			key += 1;
			Destroy (col.gameObject);
			t1.text = "Keys:" + key.ToString ();

		}
			

		else if (col.gameObject.CompareTag ("villian")) {
				Destroy (gameObject);
			SceneManager.LoadScene (8);
			coins = 0;
			HighScore = coins;
			t3.text = "HighScore:" + HighScore.ToString ();

			}

		}

	public void Scene(){

		if (key >= 6) {
			SceneManager.LoadScene (nextscene);

	}

	}


	public void Score(){
		if (coins >= HighScore) {
			HighScore = coins;
			t3.text = "HighScore:" + HighScore.ToString ();

		}

	    
	}




}


