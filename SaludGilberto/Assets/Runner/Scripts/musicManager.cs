using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
        GameObject[] gTemp = GameObject.FindGameObjectsWithTag(this.tag);
        if (gTemp.Length > 1)
            Destroy(gameObject);
	}
	
	
}
