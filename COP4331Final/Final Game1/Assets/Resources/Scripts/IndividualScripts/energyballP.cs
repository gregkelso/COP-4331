using UnityEngine;
using System.Collections;

public class energyballP : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.up * speed * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            //attackEnemy()
            Destroy(gameObject);
        }

    }
}
