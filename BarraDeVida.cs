using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BarraDeVida : MonoBehaviour {

    [SerializeField]GameObject blood;
    [SerializeField]GameObject barra;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void SetBarra(string valor)
    {
        if (valor == "ativar") ;
        {
            gameObject.SetActive(true);
            Life();
        }

        if (valor == "desativar")
        {
            gameObject.SetActive(false);
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
