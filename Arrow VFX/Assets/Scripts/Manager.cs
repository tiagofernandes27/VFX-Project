using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Manager : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject implosion;
    public GameObject arrow;

    private GameObject effectToSpawn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SpawnVFX();
        }
    }

    void SpawnVFX()
    {
        if (firePoint != null)
        {
            StartCoroutine(Sequence());
        }
        else
        {
            Debug.Log("No Fire Point");
        }
    }

    IEnumerator Sequence()
    {
        Instantiate(implosion, firePoint.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Instantiate(arrow, firePoint.transform.position, Quaternion.identity);
    }
}
