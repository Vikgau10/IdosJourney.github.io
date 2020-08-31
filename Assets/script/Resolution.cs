using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour {

	public int height;
	public int width;


	public void SetWidth(int w){

		width = w;
	}

	public void  SetHeight(int h){

		height = h;
	}


	public void SetResolution(){
		Screen.SetResolution (width,height,false);

	}

}
