using UnityEngine;
using System.Collections;

public class EndGameDestroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
			Application.LoadLevel("Menu");	
		}
}

		
	


