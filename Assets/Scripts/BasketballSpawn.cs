using UnityEngine;
using System.Collections;

public class BasketballSpawn : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float speed = 5.0f;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rigidbody = instance.GetComponent<Rigidbody>();
            rigidbody.velocity = Vector3.left * speed;
        }
    }

    private void SpawnBall(KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rigidbody = instance.GetComponent<Rigidbody>();
            // rigidbody.velocity = Vector3.left * vel;
        }
    }
}
