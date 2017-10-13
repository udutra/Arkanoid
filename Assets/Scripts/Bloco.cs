using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bloco : MonoBehaviour {

	public Rigidbody2D m_Rigidbody;
	public BoxCollider2D m_Collider; 

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Collider = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		m_Rigidbody.constraints = new RigidbodyConstraints2D ();
		m_Collider.isTrigger = true;
	}
}
