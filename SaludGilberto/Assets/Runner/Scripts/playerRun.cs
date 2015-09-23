using UnityEngine;
using System.Collections;

public class playerRun : MonoBehaviour {

    public float speed, percentage;
    private bool down, middle, up, bMoving, bDir; 
    private Vector3 vPosGoal;
    

    void Start()
    {
        down = true;
        middle = false;
        up = false;
        bMoving = false; //True if its in the air
        vPosGoal = transform.position;
        bDir = true; //If true is going Up , if false is going down
    }

    // Update is called once per frame
    void Update()
    {
        //DEFINE LINE
        //this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && !bMoving)
        {
            if (down)
            {
                down = up = false;
                middle = true;
                vPosGoal = transform.position + Vector3.up;
                bDir = true;
                //this.transform.position += Vector3.up;
            } 
            else if (middle)
            {
                down = middle = false;
                up = true;
                vPosGoal = transform.position + Vector3.up;
                bDir = true;
                //this.transform.position += Vector3.up;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !bMoving)
        {
            if (up)
            {
                up = down = false;
                middle = true;
                vPosGoal = transform.position - Vector3.up;
                bDir = false;
                //this.transform.position -= Vector3.up;
            }
            else if (middle)
            {
                middle = up = false;
                down = true;
                vPosGoal = transform.position - Vector3.up;
                bDir = false;
                //this.transform.position -= Vector3.up;
            }
        }


        //MOVE TO LINE
        if(up)
        {
            transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage);
            
        }else if(middle)
        {            
            transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage);
        }
        else if(down)
        {            
            transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage);
        }

        //Check if it is at the goal position
        if (transform.position == vPosGoal)
        {
            bMoving = false;
        }
        else
        {
            bMoving = true;
        }

    }

    Vector3 vMoveFromTo(Vector3 v3PosInit, Vector3 v3PosFin, float fTime, float fPerc)
    {
        Vector3 vReturn;
        //Checar porcentaje
        if (bDir && v3PosInit.y >= (v3PosFin.y * fPerc) / 100)
        {
            vReturn = v3PosFin;
        }else if(!bDir && v3PosInit.y <= (v3PosFin.y * fPerc) / 100)
            vReturn = v3PosFin;
        else
            vReturn = Vector3.Lerp(v3PosInit, v3PosFin, fTime); 
        return vReturn;
    }

}
