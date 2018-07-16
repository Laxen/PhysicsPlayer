using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	private Rigidbody2D rb;

	public float speed;
	public float superSpeed;

	public GameObject wall;
	// public float xOffset;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate() {
		Vector2 v = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		if (Input.GetKey(KeyCode.LeftShift)) 
			rb.velocity = v * superSpeed;
		else
			rb.velocity = v * speed;
	}

	// void OnDrawGizmos() {
	// 	Vector3 skrra = wall.transform.position;
	// 	skrra.x -= xOffset;

	// 	Gizmos.DrawLine(transform.position, skrra);
	// }
}