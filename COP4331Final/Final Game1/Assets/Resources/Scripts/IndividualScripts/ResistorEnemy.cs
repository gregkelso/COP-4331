﻿using UnityEngine;
using System.Collections;

public class ResistorEnemy : EnemyController
{

    private GameObject player;
    private bool detected;
    GameObject lightningPrefab;
    //Initialize controller and parent
    protected override void Start()
    {
        base.Start();
        detected = false;
        //Cache Waypoint prefab
        lightningPrefab = Resources.Load("Prefabs/lightning") as GameObject;
        rb.mass = 4;
        health = 100;
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
        base.onDetect(player);
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
            Debug.Log("Hit" + health);
            health -= 51;
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
            lightning.transform.Translate(new Vector3(0, 50, 0));
        }

    }

    public override void onExit()
    {
        base.onExit();
        detected = false;
        GetComponent<Seek>().deactivate(player);
    }
}
