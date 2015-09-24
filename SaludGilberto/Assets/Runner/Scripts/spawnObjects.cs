using UnityEngine;
using System.Collections;

public class spawnObjects : MonoBehaviour
{

    public Transform pos;
    public GameObject objMalo, objBueno;
    public int iBuenos = 5;
    //public Sprite[] sprites;
    //private SpriteRenderer spriteR;

    // Use this for initialization
    void Start()
    {
        //spriteR = prefab.GetComponent<SpriteRenderer>();
        InvokeRepeating("SpawnObjects", 0, 1f);
    }

    void SpawnObjects()
    {
        int iCont = 0;
        bool bSpawned = false;

        if ((int)Mathf.Floor(Random.Range(0,2)) == 1) //Linea 1
        {
            bSpawned = true;
            int num = (int)Mathf.Floor(Random.Range(0, 15));

            if(num > iBuenos)
                Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y + 1.0f, pos.position.z), pos.rotation);
            else
                Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y + 1.0f, pos.position.z), pos.rotation);

            iCont++;
        }
        
        if((int)Mathf.Floor(Random.Range(0, 2)) == 1) //Linea 2
        {
            bSpawned = true;
            int num = (int)Mathf.Floor(Random.Range(0, 15));

            if (num > iBuenos)
                Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y, pos.position.z), pos.rotation);
            else
                Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y, pos.position.z), pos.rotation);
            iCont++;
        }

        if (iCont < 2 && (int)Mathf.Floor(Random.Range(0, 2)) == 1) //Linea 3
        {
            bSpawned = true;
            int num = (int)Mathf.Floor(Random.Range(0, 15));

            if (num > iBuenos)
                Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y - 1.0f, pos.position.z), pos.rotation);
            else
                Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y - 1.0f, pos.position.z), pos.rotation);
        }

        if(!bSpawned)
        {

            int num = (int)Mathf.Floor(Random.Range(0, 15));
            if (num > iBuenos)
            {
                int iNum2 = (int)Mathf.Floor(Random.Range(1, 4));
                if(iNum2 == 1)
                    Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y - 1.0f, pos.position.z), pos.rotation);
                else if(iNum2 == 2)
                    Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y, pos.position.z), pos.rotation);
                else
                    Instantiate(objMalo, new Vector3(pos.position.x, pos.position.y + 1.0f, pos.position.z), pos.rotation);

            }
            else
            {
                int iNum2 = (int)Mathf.Floor(Random.Range(1, 4));
                if (iNum2 == 1)
                    Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y - 1.0f, pos.position.z), pos.rotation);
                else if (iNum2 == 2)
                    Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y, pos.position.z), pos.rotation);
                else
                    Instantiate(objBueno, new Vector3(pos.position.x, pos.position.y + 1.0f, pos.position.z), pos.rotation);
            }
            
                
        }


          
           

        /*
        switch (num)
        {
            case 1:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, pos.position, pos.rotation);
                    break;
                }
            case 2:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1f), pos.rotation);
                    break;
                }
            case 3:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1f), pos.rotation);
                    break;
                }
            case 4:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    int num3 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1f), pos.rotation);
                    if (num3 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num3 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1f), pos.rotation);
                    break;
                }
            case 5:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    int num3 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, pos.position, pos.rotation);
                    if (num3 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num3 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1f), pos.rotation);
                    break;
                }
            case 6:
                {
                    int num2 = (int)Mathf.Floor(Random.Range(0, 15));
                    int num3 = (int)Mathf.Floor(Random.Range(0, 15));
                    if (num2 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num2 % (sprites.Length - 1)];
                    Instantiate(prefab, pos.position, pos.rotation);
                    if (num3 > 4)
                        spriteR.sprite = sprites[4];
                    else
                        spriteR.sprite = sprites[num3 % (sprites.Length - 1)];
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1f), pos.rotation);
                    break;
                }
            default:
                break;
        }
        */
    }
}