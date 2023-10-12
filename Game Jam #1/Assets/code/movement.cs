using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
        public float xmul;
    private float xvel;
    private float yvel;
    public float high;
    public float thrust = 5.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(xmul, 0, 0));
            //transform.Translate(Vector3.right*xmul);
            xvel+=xmul;
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-1*xmul, 0, 0));
            //transform.Translate(Vector3.left*xmul);
            xvel-=xmul;
        }
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector3(0, high, 0));
        }
        //transform.ranslate(Vector3.right*xvel);
    }
}
