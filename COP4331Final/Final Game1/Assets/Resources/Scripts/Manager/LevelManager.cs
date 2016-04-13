using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
    private int door;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
        door = 0;
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
        SceneManager.LoadScene(sceneName);
        this.door = door;
        
    }

    void OnLevelWasLoaded(int level)
    {
        Debug.Log("level loaded" + level + " " + this);
        if (door != 0)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            GameObject doorOut = GameObject.FindGameObjectWithTag("Door" + door);
            Vector3 distance = doorOut.transform.position - player.transform.position;
            player.gameObject.transform.Translate(distance * 0.8F);
            door = 0;
        }
    }
}
