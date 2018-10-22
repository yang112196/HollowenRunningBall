using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody rb;
    public float horizVel;
    public KeyCode moveL;
    public KeyCode moveR;
    public bool isLocked;
    public int laneNum;

	// Use this for initialization
	void Start () {

        rb = GetComponent < Rigidbody > ();

        horizVel = 0;

        laneNum = 2;

        isLocked = false;

	}
	
	// Update is called once per frame
	void Update () {

        rb.velocity = new Vector3(horizVel, 0, 4);
        if (Input.GetKeyDown(moveL) && (laneNum > 1) && !isLocked){
            horizVel = -2;
            StartCoroutine(stopSlide());
            laneNum--;
            isLocked = true;
        }
        if (Input.GetKeyDown(moveR) && (laneNum < 3) && !isLocked)
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum++;
            isLocked = true;
        }

    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.5f);
        horizVel = 0;
        isLocked = false;
    }
}
