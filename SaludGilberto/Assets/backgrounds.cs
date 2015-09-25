using UnityEngine;
using System.Collections;

public class backgrounds : MonoBehaviour {

    public GameObject[] arrBackgrounds;
    public GameObject[] arrFloor;
    private int num = 0, num2 = 0;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("move", 44f, 44f);
        InvokeRepeating("moveFloor", 6.3f, 6.3f);
    }

    void move()
    {
        if (Time.timeScale>0)
        {
            num = num % arrBackgrounds.Length;
            arrBackgrounds[num].transform.position = new Vector2(24.36f, -1.39f);
            Debug.Log(arrBackgrounds[num].transform.position.x);
            num++;
        }
    }

    void moveFloor()
    {
        if (Time.timeScale>0)
        {
            num2 = num2 % arrFloor.Length;
        arrFloor[num2].transform.position = new Vector2(37f, 2.84f); //13
        num2++;
        } 
    }
}
