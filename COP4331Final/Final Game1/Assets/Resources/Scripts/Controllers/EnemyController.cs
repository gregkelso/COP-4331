using UnityEngine;
using System.Collections;

//Basic Enemy Controller
public class EnemyController : Controller {
    private GameObject player;
    private bool detected;
    //Initialize controller and parent
    protected override void Start() {
        base.Start();
        detected = false;
    }

    //Update is called once per frame
    protected override void Update() {
        base.Update(); //Call parent update

        if(detected)
        {
            //moveForward(500);
        }
    }

    public void onDetect(GameObject player)
    {
        detected = true;
        this.player = player;
        GetComponent<Seek>().activate(player);
    }
}
