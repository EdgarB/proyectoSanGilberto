using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public Transform position;
    public GameObject soap;
	// Update is called once per frame
	void Update () {
	    if (Input.GetAxis("Fire1")>0)
        {
            GameObject clone;
            if (playerMovement.lookingRight)
            {
                clone = (GameObject)Instantiate(soap, position.position + new Vector3(1, 0, 0), position.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * 10);
            }
            else if (playerMovement.lookingLeft)
            {
                clone = (GameObject)Instantiate(soap, position.position + new Vector3(-1, 0, 0), position.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * -10);
            }
                
        }
	}
}
