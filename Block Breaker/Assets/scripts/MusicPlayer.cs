using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer = null;

    void Awake () //this is the first method that is run in Unity
    { 
        //if myMusicPlayer is the 1st instance 
        if (myMusicPlayer == null)
        {
            //myMusicPlayer = 1st sound object 
            myMusicPlayer = this;

            print("Sound objcet" + this.gameObject.GetInstanceID().ToString());
            print("First sound object");

            //this.gameObject = the game Object attached to this
            //script, in our case SoundObject
            //DontDestroyOnLoad = do not destroy the gameObject
            //when changeing scenes
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        //if myMusicPlayer != null
        //if SoundObject already exists
        else
        {
            print("Sound objcet" + this.gameObject.GetInstanceID().ToString());

            //destroy the 2nd gameObject created
            Destroy(this.gameObject);
        }
    }

	void Start ()
    {

    }
	
	void Update ()
    {
		
	}
}
