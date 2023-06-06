using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scripts
{
    public class Keys : MonoBehaviour
    {
        [SerializeField] GameObject _restartPanel;
        [SerializeField] Movement _playerMovement;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (collision.transform.GetComponent<Key>().MinusHp())
                {
                    
                }
                gameObject.SetActive(false);
            }
        }
    }
}
