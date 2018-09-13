using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour {

    protected Joystick joystick;
    protected Joybutton joybutton;

    // Use this for initialization
    void Start () {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
	}
	
	// Update is called once per frame
	void Update () {

        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * 50, joystick.Vertical * 50);
	}
}
