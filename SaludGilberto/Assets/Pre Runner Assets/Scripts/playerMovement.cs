using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public Vector3 moveDirection;
    public SpriteRenderer sprite;
    public Sprite idleLeft, idleRight, shootingLeft, shootingRight/*, facingUp, facingDown;*/;
    public static bool lookingLeft, lookingRight;

	// Use this for initialization
	void Start () {
        moveDirection = new Vector3(0, 0, 0);
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = idleRight;
        lookingLeft = false;
        lookingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetAxisRaw("Horizontal")!=0)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                sprite.sprite = shootingRight;
                lookingRight = true;
                lookingLeft = false;
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                sprite.sprite = shootingLeft;
                lookingLeft = true;
                lookingRight = false;
            }
            moveDirection.Set(Input.GetAxisRaw("Horizontal"), 0, 0);
            transform.Translate(moveDirection * 0.05f);
        }
        else if (Input.GetAxisRaw("Horizontal")==0 && Input.GetAxisRaw("Fire1")==0)
        {
            if (lookingRight)
                sprite.sprite = idleRight;
            else
                sprite.sprite = idleLeft;
        }

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            moveDirection.Set(0, Input.GetAxisRaw("Vertical"), 0);
            transform.Translate(moveDirection * 0.05f);
        }

        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sprite.sprite = shootingLeft;
            lookingLeft = true;
            lookingRight = false;
        } 
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sprite.sprite = shootingRight;
            lookingRight = true;
            lookingLeft = false;
        }
        /*else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sprite.sprite = facingUp;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sprite.sprite = facingDown;
        }*/
    }
}
