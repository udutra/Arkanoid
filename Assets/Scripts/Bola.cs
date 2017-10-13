using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

    public Vector2 velocidade;

	// Use this for initialization
	void Start () {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(velocidade);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
