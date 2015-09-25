using UnityEngine;
using System.Collections;

public class playerRun : MonoBehaviour {

    public float speed, percentage;
    public GameObject gLifeManagerBar;
    private float fDistance;
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
        fDistance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale>0)
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
                    fDistance = Vector3.Distance(transform.position, vPosGoal);
                    //this.transform.position += Vector3.up;
                }
                else if (middle)
                {
                    down = middle = false;
                    up = true;
                    vPosGoal = transform.position + Vector3.up;
                    bDir = true;
                    fDistance = Vector3.Distance(transform.position, vPosGoal);
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
                    fDistance = Vector3.Distance(transform.position, vPosGoal);
                    //this.transform.position -= Vector3.up;
                }
                else if (middle)
                {
                    middle = up = false;
                    down = true;
                    vPosGoal = transform.position - Vector3.up;
                    bDir = false;
                    fDistance = Vector3.Distance(transform.position, vPosGoal);
                    //this.transform.position -= Vector3.up;
                }
            }


            //MOVE TO LINE
            if (up)
            {
                transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage, bDir, fDistance);

            }
            else if (middle)
            {
                transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage, bDir, fDistance);
            }
            else if (down)
            {
                transform.position = vMoveFromTo(transform.position, vPosGoal, speed, percentage, bDir, fDistance);
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
    }

    Vector3 vMoveFromTo(Vector3 v3PosInit, Vector3 v3PosFin, float fTime, float fPerc ,bool bDirection, float fDistance)
    {
        Vector3 vReturn;
        float fDif;

        if (bDirection)
            fDif = v3PosFin.y - (fDistance * fPerc) /100;
        else
            fDif = v3PosFin.y + (fDistance * fPerc) / 100;

        if (bDirection && v3PosInit.y > fDif)
        {
            vReturn = v3PosFin;
        }
        else if(!bDirection && v3PosInit.y < fDif)
        {
            vReturn = v3PosFin;
        }else
            vReturn = Vector3.Lerp(v3PosInit, v3PosFin, fTime);

        return vReturn;
        //Checar porcentaje
        /*
        if (bDirection && v3PosInit.y >= v3PosFin.y - ((v3PosFin.y * fPerc) / 100))
        {
            vReturn = v3PosFin;
        }else if (!bDirection && v3PosInit.y <= v3PosFin.y - ((v3PosFin.y * fPerc) / 100))
            vReturn = v3PosFin;
        else
            vReturn = Vector3.Lerp(v3PosInit, v3PosFin, fTime); 
        */
        //return vReturn;
    }

    void OnTriggerEnter2D(Collider2D cOther)
    {
        if(cOther.gameObject.tag == "Bueno")
        {
            gLifeManagerBar.GetComponent<lifeManager>().addOrRestToLife(2);
            Destroy(cOther.gameObject);
            //Debug.Log("Aumenta vida");
        }else if (cOther.gameObject.tag == "Malo")
        {
            gLifeManagerBar.GetComponent<lifeManager>().addOrRestToLife(-2);
            Destroy(cOther.gameObject);
            //Debug.Log("Decrementa vida");
        }

    }

}
