using UnityEngine;
using System.Collections;

public class moveBack : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * -5 * Time.deltaTime);
	}
}
