using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

    public float Velocidade = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D m_Rigidbody;


	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        HorizontalAxis = Input.GetAxis("Horizontal");
		m_Rigidbody.velocity = new Vector2(Velocidade * HorizontalAxis, 0);
	}
}
