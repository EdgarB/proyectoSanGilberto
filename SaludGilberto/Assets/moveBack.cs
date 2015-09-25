using UnityEngine;
using System.Collections;

public class moveBack : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Time.timeScale > 0)
            this.transform.Translate(Vector3.right * -.06f);
	}
}
