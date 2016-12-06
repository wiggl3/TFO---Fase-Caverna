using UnityEngine;
using System.Collections;

public class Formigas : MonoBehaviour {

	//public GameObject blood;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//Instantiate(blood, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy (gameObject);
			//blood.SetActive(true);
			//gameObject.SetActive (false);
		}
	}
}
