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
    }

    //Update is called once per frame
    protected override void Update()
    {
        base.Update(); //Call parent update
        
        if (detected)
        {
            //moveForward(500);
        }
    }


    public override void onDetect(GameObject player)
    {
        Debug.Log("detected");
        detected = true;
        this.player = player;
        GetComponent<Seek>().activate(player);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            attack();
        }

    }

    void attack()
    {
        if (transform.childCount == 2)
        {
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
