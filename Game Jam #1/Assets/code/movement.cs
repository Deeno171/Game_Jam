using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float xmul;
    private float xvel;
    private float yvel;
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right*xmul);
            xvel+=xmul;
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left*xmul);
            xvel-=xmul;
        }
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up*5);
        }
        //transform.ranslate(Vector3.right*xvel);
    }
}
