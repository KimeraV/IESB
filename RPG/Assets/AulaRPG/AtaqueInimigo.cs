using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueInimigo : MonoBehaviour
{
    Animator ataque;

    // Start is called before the first frame update
    void Start()
    {
        ataque = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ataque.SetBool("Atacando", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ataque.SetBool("Atacando", false);
        }
    }
}
