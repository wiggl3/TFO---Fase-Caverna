using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Nashor : MonoBehaviour {

	public int hp = 100;
	[SerializeField] GameObject ataque;
	[SerializeField] Transform capsula;
	bool podeAtacar;
	Animator nashorMove;
	int sortAnim;
	bool changeAnim = true;
    [SerializeField]GameObject blood;
	[SerializeField]GameObject soParaAtiverEssaPorra;
	
	// Use this for initialization
	void Start () 
	{
		nashorMove = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (sortAnim == 0) 
		{
			nashorMove.SetInteger ("Move", 0);
			ataque.SetActive(false);
		}

		if (sortAnim == 1) 
		{
			nashorMove.SetInteger ("Move", 1);
			ataque.SetActive(false);
		}
		
		else if (sortAnim == 2) 
		{
			nashorMove.SetInteger ("Move", 2);
			ataque.SetActive(true);
		}
		
		else if (sortAnim == 3)
		{
			nashorMove.SetInteger ("Move", 3);
			ataque.SetActive(true);
		}
		
		else if (sortAnim == 4) 
		{
			nashorMove.SetInteger ("Move",4);
			ataque.SetActive(true);
		}

		else if (sortAnim == 5) 
		{
			nashorMove.SetInteger ("Move",5);
			ataque.SetActive(true);
		}

		

	}
	
	void sortMove()
	{
		sortAnim = Random.Range (1, 5);
	}
	
	IEnumerator canChange()
	{
		yield return new WaitForSeconds (3);
		changeAnim = true;
	}

//jogador dentro do raio de açao do nashor.
	void OnTriggerEnter(Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
			podeAtacar = true;
			soParaAtiverEssaPorra.SetActive(true);
		}

	}

	void OnTriggerStay(Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
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
		
	}


	void OnTriggerExit (Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
			podeAtacar = false;
			sortAnim = 0;

			if (podeAtacar == false)
			{
				ataque.SetActive(false);
			}
		}
	}

	//Colisao entre jogador e o nashor. Tirando sangue do nashor
	void OnCollisionEnter (Collision sangue)
	{
		if (sangue.gameObject.tag == "Player") 
		{
			hp -= 10;
			Life ();


			if (hp <= 0)
			{
				Destroy (gameObject);
				soParaAtiverEssaPorra.SetActive(false);
			}
		}
	}

	void Life()
	{
		if (blood.transform.localScale.x < 0) 
		{
		 SceneManager.LoadScene("GameOver");
		}
		else 
		{
			blood.transform.localScale -= new Vector3 (5f * Time.deltaTime, 0, 0); 
		}
	}

}
