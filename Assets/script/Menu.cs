﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	

	public void Play(){
		SceneManager.LoadScene (2);


	}

	public void Quit(){
		Application.Quit ();

	}

	public void Instruction(){
		SceneManager.LoadScene (1);

	}


	public void Main(){
		SceneManager.LoadScene(0);

	}



}
