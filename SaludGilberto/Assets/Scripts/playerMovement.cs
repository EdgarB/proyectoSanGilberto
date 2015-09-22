using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public Vector3 moveDirection;
    public SpriteRenderer sprite;
    public Sprite facingLeft, facingRight, facingUp, facingDown;

	// Use this for initialization
	void Start () {
        moveDirection = new Vector3(0, 0, 0);
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetAxisRaw("Horizontal")!=0)
        {
            moveDirection.Set(Input.GetAxisRaw("Horizontal"), 0, 0);
            transform.Translate(moveDirection * 0.05f);
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            moveDirection.Set(0, Input.GetAxisRaw("Vertical"), 0);
            transform.Translate(moveDirection * 0.05f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sprite.sprite = facingLeft;
        } 
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sprite.sprite = facingUp;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sprite.sprite = facingRight;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sprite.sprite = facingDown;
        }
    }
}
