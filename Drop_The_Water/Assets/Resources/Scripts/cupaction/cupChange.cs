using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		Vector3 direction = this.transform.position;
		
		if(other.gameObject.tag.Equals("waterdrop"))
		{
			Destroy(other.gameObject);
			GameObject changecup = GameObject.Find("cup_2");
			changecup.transform.position = direction;
			Destroy(this.gameObject);
		}
	}
}
