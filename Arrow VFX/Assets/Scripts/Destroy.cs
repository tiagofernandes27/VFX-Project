using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, this.gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
