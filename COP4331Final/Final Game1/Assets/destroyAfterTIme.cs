using UnityEngine;
using System.Collections;

public class destroyAfterTIme : MonoBehaviour {
    public float secondsToDestroy;
    private float startTime;


	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - startTime > secondsToDestroy)
            Destroy(gameObject);
	}
}
