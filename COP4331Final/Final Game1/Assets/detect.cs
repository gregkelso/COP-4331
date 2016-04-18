using UnityEngine;
using System.Collections;

public class detect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            gameObject.transform.parent.GetComponent<EnemyController>().onDetect(coll.gameObject);
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            gameObject.transform.parent.GetComponent<EnemyController>().onExit();
    }
}
