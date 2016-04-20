using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
    PathFinder pathFinder;
    // Use this for initialization
	void Start () {
        LayerMask mask = 1 << 9; //Consider obstacles non-traversable
        pathFinder = new PathFinder(20, mask); //Initialize PathFinder
    }
	
	// Update is called once per frame
	void Update () {
        pathFinder.getGrid().generate(); //Regenerate grid
    }
    void Awake()
    {
        Debug.Log("awake");
    }

    public void loadNextScene(string sceneName, int door)
    {
       
        
    }


    public void moveCamera(int position)
    {

    }

    public PathFinder getPathFinder()
    {
        return pathFinder;
    }
}
