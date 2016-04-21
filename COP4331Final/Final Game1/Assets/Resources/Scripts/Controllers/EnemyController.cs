using UnityEngine;
using System.Collections;
using System;

//Basic Enemy Controller
public class EnemyController : Controller {
    public int health;
    public virtual void onDetect(GameObject player)
    {

    }

    public virtual void onExit()
    {

    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (health < 0)
            Destroy(gameObject);

    }

}
