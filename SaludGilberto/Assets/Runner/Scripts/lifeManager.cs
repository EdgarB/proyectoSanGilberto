using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class lifeManager : MonoBehaviour {


    public float fLifeTimeSeconds = 10.0f;
    private float fFill;
    private float fRealScondsSinceLoad;
    private float fExtraSeconds;
	void Awake()
    {
        fExtraSeconds = 0.0f;
        fRealScondsSinceLoad = Time.time;
        fFill = 1;

    }
    
	// Update is called once per frame
	void LateUpdate () {
        if (Time.timeScale>0)
        {
            if (GetComponent<Image>().fillAmount > 0.0f)
            {
                fFill = (fLifeTimeSeconds - (Time.time - fRealScondsSinceLoad) + fExtraSeconds) / fLifeTimeSeconds; //Calculate quantity of fillAmount

                if (fFill >= 1)
                    fFill = 1;
                else if (fFill < 0)
                    fFill = 0;

                GetComponent<Image>().fillAmount = fFill;
            }
        }  
	}

     public void addOrRestToLife(float fSeconds)
    {
        if(fSeconds <= fLifeTimeSeconds && (fLifeTimeSeconds - (Time.time - fRealScondsSinceLoad) + fExtraSeconds) /fLifeTimeSeconds <= 1.0f)
            fExtraSeconds += fSeconds;

    }
}
