using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject key;
    public bool haveKey = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == key)
        {
            haveKey= true;
            //key.SetActive(false);
        }
    }
}