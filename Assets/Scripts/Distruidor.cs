using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Distruidor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collsion)
    {
        GameObject collider = collsion.collider.gameObject;
        GameObject.Destroy(collider);
    }

	void OnTriggerEnter2D(Collider2D collider){
		GameObject.Destroy (collider.gameObject);
	}
}
