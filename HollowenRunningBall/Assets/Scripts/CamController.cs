using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {
    //public Rigidbody rb;
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>();
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //rb.velocity = new Vector3(0,0,4);
        this.transform.position = player.transform.position + offset;
    }
}
