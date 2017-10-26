using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaer : MonoBehaviour {

    static MusicPlaer myMusicPlayer = null;

    void Awake()
    {
        if (myMusicPlayer == null)
        {



            myMusicPlayer = this;
            print("Sound object" + this.gameObject.GetInstanceID().ToString());
            print("First Object");
            //this 
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            print("Sound object" + this.gameObject.GetInstanceID().ToString());

            Destroy(this.gameObject);
        }

    }

    // Use this for initialization
    void Start() {
        

		
	}
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
