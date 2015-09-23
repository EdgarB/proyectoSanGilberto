using UnityEngine;
using System.Collections;

public class playerRun : MonoBehaviour {

    public float speed;
    private bool down, middle, up;

    void Start()
    {
        down = true;
        middle = false;
        up = false;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (down)
            {
                down = up = false;
                middle = true;
                this.transform.position += Vector3.up*1.7f;
            } 
            else if (middle)
            {
                down = middle = false;
                up = true;
                this.transform.position += Vector3.up*1.7f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (up)
            {
                up = down = false;
                middle = true;
                this.transform.position -= Vector3.up*1.7f;
            }
            else if (middle)
            {
                middle = up = false;
                down = true;
                this.transform.position -= Vector3.up*1.7f;
            }
        }
    }
}
