using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bloco : MonoBehaviour {

	public Rigidbody2D rigidbody;
	public BoxCollider2D collider; 

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		collider = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		rigidbody.constraints = new RigidbodyConstraints2D ();
		collider.isTrigger = true;
	}
}
