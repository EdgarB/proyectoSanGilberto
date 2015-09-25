using UnityEngine;
using System.Collections;

public class backgrounds : MonoBehaviour {

    public GameObject[] arrBackgrounds;
    public GameObject[] arrFloor;
    private int num = 0, num2 = 0;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("move", 41f, 41f);
        InvokeRepeating("moveFloor", 5.3f, 5.3f);
    }

    void move()
    {
        if (Time.timeScale>0)
        {
            num = num % 2;
            arrBackgrounds[num].transform.position = new Vector2(10.03f, -1.39f);
            Debug.Log(arrBackgrounds[num].transform.position.x);
            num++;
        }
    }

    void moveFloor()
    {
        if (Time.timeScale>0)
        {
            num2 = num2 % 2;
        arrFloor[num2].transform.position = new Vector2(13f, 2.84f);
        num2++;
        }
        
    }
}
