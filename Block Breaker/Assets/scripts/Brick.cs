using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    private int numberOfHits;
    bool IsBreakable = false;
    void HandleHits()
    {
        numberOfHits++;
        print(numberOfHits);

        if (numberOfHits >= maxHits)
        {
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        IsBreakable = (this.tag == "Break");

        if (IsBreakable)
        {
            HandleHits();
        }
    }

	// Use this for initialization
	void Start () {
		
	}
    
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
