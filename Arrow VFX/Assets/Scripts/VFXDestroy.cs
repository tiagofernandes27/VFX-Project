using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXDestroy : MonoBehaviour
{
    private void Awake()
    {
        Destroy(this.gameObject, GetComponent<ParticleSystem>().main.duration - 1);
    }
}
