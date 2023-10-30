using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public float bounce = 80f;

    // The correct method signature should include the 'Collision' parameter.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Use 'Rigidbody' instead of 'Rigidbody3D' and 'ForceMode.Impulse' instead of 'ForceMode3D.Impulse'.
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * bounce, ForceMode.Impulse);
        }
    }
}