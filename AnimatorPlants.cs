using UnityEngine;
using System.Collections;

public class AnimatorPlants : MonoBehaviour {

	Animator plantsMove;
    int sortAnim;
	public bool changeAnim = true;

	// Use this for initialization
	void Start () 
	{
		plantsMove = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (sortAnim == 1) 
		{
			plantsMove.SetInteger ("Move", 1);
		}

		if (sortAnim == 2) 
		{
			plantsMove.SetInteger ("Move", 2);
		}

		if (sortAnim == 3)
		{
			plantsMove.SetInteger ("Move", 3);
		}

		if (sortAnim == 4) 
		{
			plantsMove.SetInteger ("Move",4);
		}

		if (changeAnim == true) 
		{
			sortMove ();
			StartCoroutine("canChange");
			sortMove ();
			changeAnim = false;
		}

		if (changeAnim == false) 
		{

		}
	}

	void sortMove()
	{
		sortAnim = Random.Range (1, 4);
	}

	IEnumerator canChange()
	{
		yield return new WaitForSeconds (3);
		changeAnim = true;
	}
}
