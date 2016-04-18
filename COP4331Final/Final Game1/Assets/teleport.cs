using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {
    public string scene;
    public int outDoor;

    GameObject cam;
    GameObject player;
	// Use this for initialization
	void Start () {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Got collide");
            switch (outDoor)
            {
                case 1:
                    cam.transform.position = new Vector3(-1245, -895, -574);
                    player.transform.position = new Vector3(-1070, -580, 0);
                    player.GetComponent<Controller>().setHeading(180);
                    break;
                case 2:
                    cam.transform.position = new Vector3(-128, 811, -574);
                    player.transform.position = new Vector3(-800, 746, 0);
                    //player.transform.localEulerAngles = new Vector3(0, 0, 270);
                    player.GetComponent<Controller>().setHeading(270);
                    break;
                case 3:
                    cam.transform.position = new Vector3(-128, 811, -574);
                    player.transform.position = new Vector3(-139, 500, 0);
                    player.GetComponent<Controller>().setHeading(0);
                    break;
                case 4:
                    cam.transform.position = new Vector3(-128, -33, -574);
                    player.transform.position = new Vector3(-139, 275, 0);
                    player.GetComponent<Controller>().setHeading(180);
                    GameObject.FindGameObjectWithTag("redbg").GetComponent<SpriteRenderer>().enabled = true;
                    break;
            }
            
            
        }

    }
}
