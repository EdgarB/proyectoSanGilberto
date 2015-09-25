using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showHighscore : MonoBehaviour {

    public Text highscore;

	// Use this for initialization
	void Start () {
        highscore.text = ((int)Mathf.Floor(scoreManager.fScore)).ToString();
	}
}
