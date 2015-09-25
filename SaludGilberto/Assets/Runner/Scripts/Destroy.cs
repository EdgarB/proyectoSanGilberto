using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bueno" || other.tag == "Malo" || other.tag == "Cartel")
            Destroy(other.gameObject);
        else if (other.tag == "PlayerDead")
            Application.LoadLevel("HighScore");
    }
}
