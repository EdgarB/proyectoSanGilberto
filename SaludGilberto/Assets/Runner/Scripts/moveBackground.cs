using UnityEngine;
using System.Collections;

public class moveBackground : MonoBehaviour {

    public float speed = -0.006f;
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale>0)
        {
            if (this.tag == "Background")
            {
                speed = -0.006f;
                this.transform.Translate(Vector3.right * speed);
            }

            else if (this.tag == "Floor" || this.tag == "PlayerDead")
            {
                speed = -0.06f;
                this.transform.Translate(Vector3.right * speed);
            }
        }    
	}
}
