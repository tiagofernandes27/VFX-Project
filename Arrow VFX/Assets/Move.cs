using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocity = 0.01f;
    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().position += new Vector3(0, 0, velocity);
    }
}
