using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public Transform position;
    public GameObject soap;
    public SpriteRenderer sprite;
    public Sprite shootingLeft, shootingRight;

    private float fireRate = 0.4f;
    private float nextFire = 0f;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
	    if (Input.GetAxis("Fire1")>0 && Time.time > nextFire)
        {
            GameObject clone;
            if (playerMovement.lookingRight)
            {
                sprite.sprite = shootingRight;
                clone = (GameObject)Instantiate(soap, position.position + new Vector3(1, 0, 0), position.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * 10);
            }
            else if (playerMovement.lookingLeft)
            {
                sprite.sprite = shootingLeft;
                clone = (GameObject)Instantiate(soap, position.position + new Vector3(-1, 0, 0), position.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * -10);
            }
            nextFire = Time.time + fireRate;
        }
	}
}
