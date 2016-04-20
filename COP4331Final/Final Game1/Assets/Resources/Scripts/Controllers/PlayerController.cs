using System;
using UnityEngine;
using UnityEngine.UI;

//Basic player controller
public class PlayerController : Controller {
    //Global Variables
    
    //PRIVATE
    private int health;

    //PUBLIC
	public bool limitRateOfFire = true;
    public int speed = 3;
	public float fireRate = 1;
	public float time = 0;
    public Text healthText;
    private GameObject energyPrefab;

    //Initialize controller and parent
    protected override void Start() {
        base.Start();
        health = 100;
        //healthText.text = "Health: " + health.ToString();

        energyPrefab = Resources.Load("Prefabs/energyball") as GameObject;
    }

    //Update is called once per frame
    protected override void Update () {
		processInput(); //Process Keyboard Input

        base.Update(); //Call parent update
    }

    //Process keyboard input
	void processInput() {
        //Up Arrow

		time += Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
            moveForward();

        //Down Arrow
        if (Input.GetKey(KeyCode.DownArrow))
            moveBackward();

        //Left Arrow
        if (Input.GetKey(KeyCode.LeftArrow))
            rotateLeft();

        //Right Arrow
        if (Input.GetKey(KeyCode.RightArrow))
            rotateRight();

        //Right Arrow
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Delay the fire rate
			if (limitRateOfFire) {
				if (time > fireRate) {
					attack ();
					time = 0;
				}
			} else {
				attack();
			}
		}

        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //if (horizontal != 0)
        //    moveHorizontal(horizontal);

        //if (vertical != 0)
        //    moveVertical(vertical);



    }

    private void attack()
    {
        GameObject lightning = MonoBehaviour.Instantiate(energyPrefab) as GameObject;
        lightning.transform.position = transform.position;
        lightning.transform.rotation = transform.rotation;
        lightning.transform.Translate(new Vector3(0, 50, 0));
    }

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.CompareTag("Laplace"))
		{
			limitRateOfFire = false;
			coll.gameObject.SetActive (false);
		}

	}
}