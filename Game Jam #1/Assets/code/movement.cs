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
    private int ground = 1;
    private BoxCollider boxCollider;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        boxCollider = GetComponent<BoxCollider>();


        //rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        //void OnTriggerEnter (Collision eruiuibrui){ ground = 1; Debug.Log("g1");}
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
        if (Input.GetKeyDown("space") && isgrounded())
        {
            ground = 0;
            rb.AddForce(new Vector3(0, high, 0));
        }
    }
    public bool isgrounded(){
        //bool raycastHit = Physics.BoxCast(boxCollider.bounds.center, transform.localScale, Vector3.down, Quaternion.identity, 20f);
        Vector3 vel = rb.velocity; 
        
        return vel.y==0;
    }
}
