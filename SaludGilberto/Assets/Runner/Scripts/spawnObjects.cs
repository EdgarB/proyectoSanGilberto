using UnityEngine;
using System.Collections;

public class spawnObjects : MonoBehaviour {

    public Transform pos;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnObjects", 1, 1f);
	}
	
	void SpawnObjects()
    {
        int num = (int)Mathf.Floor(Random.Range(1, 6));
        switch (num)
        {
            case 1:
                {
                    Instantiate(prefab, pos.position, pos.rotation);
                    break;
                }
            case 2:
                {
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1.7f), pos.rotation);
                    break;
                }
            case 3:
                {
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1.7f), pos.rotation);
                    break;
                }
            case 4:
                {
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1.7f), pos.rotation);
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1.7f), pos.rotation);
                    break;
                }
            case 5:
                {
                    Instantiate(prefab, pos.position, pos.rotation);
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y - 1.7f), pos.rotation);
                    break;
                }
            case 6:
                {
                    Instantiate(prefab, pos.position, pos.rotation);
                    Instantiate(prefab, new Vector3(pos.position.x, pos.position.y + 1.7f), pos.rotation);
                    break;
                }
            default:
                break;
        }
    }
}
