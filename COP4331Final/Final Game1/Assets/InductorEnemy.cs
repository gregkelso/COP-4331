using UnityEngine;
using System.Collections;

public class InductorEnemy : EnemyController {


    private GameObject player;
    private bool detected;
    GameObject lightningPrefab;
    //Initialize controller and parent
    protected override void Start()
    {
        base.Start();
        detected = false;
        //Cache Waypoint prefab
        lightningPrefab = Resources.Load("Prefabs/lightningring") as GameObject;
        health = 800;
    }

    //Update is called once per frame
    protected override void Update()
    {
        base.Update(); //Call parent update
        
        if (detected)
        {
            
        }
    }


    public override void onDetect(GameObject player)
    {
        detected = true;
        this.player = player;
        GetComponent<Seek>().activate(player);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            attack();
        }
        else if (coll.gameObject.tag == "lightningballP")
        {
            health -= 51;
            Destroy(coll.gameObject);
        }

    }

    void attack()
    {
        if (transform.childCount == 2)
        {
            Debug.Log("Got hit3");
            GameObject lightning = MonoBehaviour.Instantiate(lightningPrefab) as GameObject;
            lightning.transform.position = transform.position;
            lightning.transform.rotation = transform.rotation;
            //wp.transform.parent = obj.transform;
            lightning.transform.parent = transform;
            
        }

    }

    public override void onExit()
    {
        base.onExit();
        detected = false;
        GetComponent<Seek>().deactivate(player);
        

    }
    
}
