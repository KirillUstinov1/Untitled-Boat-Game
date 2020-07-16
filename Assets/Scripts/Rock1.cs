using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 position;
    System.Random rand = new System.Random(1);
    bool go = true;

    void Start()
    {
        int x = rand.Next(-9, 9);
        position = new Vector3(x, 6.0f, 0.0f);
    }

    // Update is called once per frame
    private void Update()
    {
        if (go)
        {
            if (transform.position.y < -6)
            {
                Vector3 scale = new Vector3(1.0f, 1.0f, 1.0f);
                transform.localScale = scale;
                int x = rand.Next(-9, 9);
                position = new Vector3(x, 6.0f, 0.0f);
                transform.position = position;
                //FindObjectOfType<P1Score>().IncreaseScore();
            }
        }
    }

    public void Stop() {
        go = false;
    }
}