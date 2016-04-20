using System;
using UnityEngine;
using UnityEngine.UI;

//Basic player controller
public class PlayerController : Controller {
    //Global Variables
    
    //PRIVATE
    private int health;

    //PUBLIC
    public int speed = 3;
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
        if (Input.GetKeyDown(KeyCode.Space))
            attack();

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
}