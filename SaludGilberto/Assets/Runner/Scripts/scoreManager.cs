using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
    private float fScore;
    void Awake()
    {
        fScore = 0;
    }

    void Update()
    {
        fScore += Time.deltaTime;
        float fScoreToShow = Mathf.Floor(fScore);
        GetComponent<Text>().text = ((int)fScoreToShow).ToString();

    }


    public void publishScore(int iSc)
    {
        bool bFounded = false;
        int iLimite = 10; //Quantity of scores that the table of scores is going to have
        for(int iC = 1; iC <= iLimite && !bFounded; iC++) //Check if there is a space on the highscore table
        {

            if (iSc > PlayerPrefs.GetInt("iHighscore_" + iC.ToString()))
            {
                bFounded = true; //The socre is higher the the one in the iC position.

                //Move all the highscores to the bottom and the last one will be overwrited
                for(int iCont = iLimite; iCont > iC; iCont++)
                {
                    int iAux = PlayerPrefs.GetInt("iHighScore_" + (iCont - 1).ToString()); 
                    PlayerPrefs.SetInt("iHigScore_" + iCont.ToString(), iAux);
                }


                PlayerPrefs.SetInt("iHighscore_" + iC.ToString(), iSc); //Overwrite the score of the player int that position

            }


        }
        
        
           


    }
}
