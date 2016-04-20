using UnityEngine;
using System.Collections;

public class towerEnemy : EnemyController {



    private GameObject player;
    private bool detected;
    GameObject lightningPrefab;
    private float lastAttackTime;
    public int direction = 1;
    

    //Initialize controller and parent
    protected override void Start()
    {
        base.Start();
        detected = false;
        //Cache Waypoint prefab
        lightningPrefab = Resources.Load("Prefabs/energyballE") as GameObject;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    //Update is called once per frame
    protected override void Update()
    {
        base.Update(); //Call parent update
        
        
        if (detected && (Time.time - lastAttackTime) > 0.8)
        {
            attack();
            lastAttackTime = Time.time;
        }
    }


    public override void onDetect(GameObject player)
    {
        Debug.Log("detected");
        detected = true;
    }

    void attack()
    {

        GameObject lightning = MonoBehaviour.Instantiate(lightningPrefab) as GameObject;
        lightning.transform.position = transform.position;
        lightning.transform.rotation = transform.rotation;
        //wp.transform.parent = obj.transform;


        GameObject lightning2 = MonoBehaviour.Instantiate(lightningPrefab) as GameObject;
        lightning2.transform.position = transform.position;
        lightning2.transform.rotation = transform.rotation;
        //wp.transform.parent = obj.transform;


        switch (direction)
        {
            case 1:
                lightning.transform.Translate(new Vector3(75, -50, 0));
                lightning.transform.Rotate(new Vector3(0, 0, -100));
                lightning2.transform.Translate(new Vector3(75, -75, 0));
                lightning2.transform.Rotate(new Vector3(0, 0, -135));
                break;
            case 2:
                lightning.transform.Translate(new Vector3(75, 50, 0));
                lightning.transform.Rotate(new Vector3(0, 0, -90));
                lightning2.transform.Translate(new Vector3(75, 75, 0));
                lightning2.transform.Rotate(new Vector3(0, 0, -45));
                break;
        }

    }

    public override void onExit()
    {
        base.onExit();
        detected = false;

    }
}
