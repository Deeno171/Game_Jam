using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixz : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 m_OriginPos;
    //private Vector3 oR;
    void Start ()
    {
        m_OriginPos = transform.position;
        //oR = transform.localrotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        currentPos.z = m_OriginPos.z;
        transform.position = currentPos;
    }
}
