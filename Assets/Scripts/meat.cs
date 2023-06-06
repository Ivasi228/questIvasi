using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat : MonoBehaviour
{
    public GameObject guyCollider;
        private void OnTriggerEnter2D(Collider2D other)
        {
            guyCollider.SetActive(false);
            this.gameObject.SetActive(false);
        }
}
