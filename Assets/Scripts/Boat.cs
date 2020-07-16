using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public Vector2 move;
    public BoxCollider2D rock1;
    public BoxCollider2D rock2;
    public BoxCollider2D rock3;
    public BoxCollider2D rock4;
    public BoxCollider2D rock5;
    public BoxCollider2D rock6;
    public BoxCollider2D boat;
    public bool go = true;
    void Start()
    {
        /*rock1 = GameObject.FindGameObjectWithTag("BadRock").GetComponent<BoxCollider2D>();
        rock2 = GameObject.FindGameObjectWithTag("BadRock (1)").GetComponent<BoxCollider2D>();
        rock3 = GameObject.FindGameObjectWithTag("BadRock (2)").GetComponent<BoxCollider2D>();
        rock4 = GameObject.FindGameObjectWithTag("BadRock (3)").GetComponent<BoxCollider2D>();
        rock5 = GameObject.FindGameObjectWithTag("BadRock (4)").GetComponent<BoxCollider2D>();
        rock6 = GameObject.FindGameObjectWithTag("BadRock (5)").GetComponent<BoxCollider2D>();
        boat = this.GetComponent<BoxCollider2D>();
        */
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            float ff = 0.0f;
            if (Input.GetKey(KeyCode.D))
            {
                ff = 0.4f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                ff = -0.4f;
            }
            move = new Vector2(ff, 0.0f);

            /*if (boat.IsTouching(rock1) || boat.IsTouching(rock2) ||
                boat.IsTouching(rock3) || boat.IsTouching(rock4) ||
                boat.IsTouching(rock5) || boat.IsTouching(rock6))
            {
                FindObjectOfType<Lose>().Over();
                FindObjectOfType<Rock1>().Stop();
                FindObjectOfType<Rock2>().Stop();
                FindObjectOfType<Rock3>().Stop();
                FindObjectOfType<Rock4>().Stop();
                FindObjectOfType<Rock5>().Stop();
                FindObjectOfType<Rock>().Stop();
                go = false;
            }*/
        }
    }

    void FixedUpdate()
    {
        moveCharacter(move);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

}
