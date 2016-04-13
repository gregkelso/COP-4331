using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {
    public string scene;
    public int outDoor;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Got collide");
            GameObject manager = GameObject.FindGameObjectWithTag("LevelManager");
            manager.GetComponent<LevelManager>().loadNextScene(scene, outDoor);
        }

    }
}
