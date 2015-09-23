using UnityEngine;
using System.Collections;

public class changeSpriteRandom : MonoBehaviour {

    public Sprite[] sSprites;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = sSprites[(int)Mathf.Floor(Random.Range(0, sSprites.Length - 1))];
	}
	
}
