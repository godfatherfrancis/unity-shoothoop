using UnityEngine;
using System.Collections;

public class BasketballSpawn : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
        Instantiate(ballPrefab);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(ballPrefab);
        }
    }
}
