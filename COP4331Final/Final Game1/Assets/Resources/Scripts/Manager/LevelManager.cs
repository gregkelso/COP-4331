using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
