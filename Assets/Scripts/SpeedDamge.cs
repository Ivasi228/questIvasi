using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedDamge : MonoBehaviour
{
    public GameObject restartPanel;
    public Rigidbody2D rb;
    public float threshold;
    float lastVel = 0;

    private void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        if(rb.velocity.magnitude != 0)
        {
            lastVel= rb.velocity.magnitude;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(lastVel > threshold)
        {
            restartPanel.SetActive(true);
        }
    }
}