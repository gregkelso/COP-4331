using UnityEngine;
using System.Collections;

public class energyballE : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //attackEnemy()
            Destroy(gameObject);
            coll.gameObject.GetComponent<PlayerController>().hitByLightningBall();
        }

    }
}
