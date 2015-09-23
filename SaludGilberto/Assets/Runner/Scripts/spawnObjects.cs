using UnityEngine;
using System.Collections;

public class spawnObjects : MonoBehaviour
{

    public Transform pos;
    public GameObject prefab;

    public Sprite[] sprites;
    private SpriteRenderer spriteR;

    // Use this for initialization
    void Start()
    {
        spriteR = prefab.GetComponent<SpriteRenderer>();
        InvokeRepeating("SpawnObjects", 1, 1f);
    }

    void SpawnObjects()
    {
        int num = (int)Mathf.Floor(Random.Range(1, 6));
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
    }
}