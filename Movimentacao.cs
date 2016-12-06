using UnityEngine;
using System.Collections;

public class Movimentacao : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3 (0/*1*Time.deltaTime * Input.GetAxisRaw ("Horizontal")*/, 0, -1*Time.deltaTime * Input.GetAxisRaw ("Vertical")));

		transform.eulerAngles += new Vector3 (0, 200 * Time.deltaTime * Input.GetAxisRaw ("Horizontal"), 0);
	
		if (Input.GetKey (KeyCode.Space)) 
		{
			rb.velocity = new Vector3 (0, 15, 0);
		}
	}
		
}
