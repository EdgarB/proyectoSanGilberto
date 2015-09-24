using UnityEngine;
using System.Collections;

public class backgrounds : MonoBehaviour {

    public GameObject[] arrBackgrounds;
    public GameObject[] arrFloor;
    private int num = 0, num2 = 0;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("move", 42.5f, 42.5f);
        InvokeRepeating("moveFloor", 6, 6);
    }

    void move()
    {
        num = num % 2;
        arrBackgrounds[num].transform.position = new Vector2(11.19f, -1.39f);
        num++;
    }

    void moveFloor()
    {
        num2 = num2 % 2;
        arrFloor[num2].transform.position = new Vector2(17.9f, 2.84f);
        num2++;
    }
}
