using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class HP : MonoBehaviour
    {
        [SerializeField] GameObject _hpPrefab;
        [SerializeField] GameObject _nullHpPrefab;
        [SerializeField] GameObject _hpPanel;
        [SerializeField] List<GameObject> _hps;
        [SerializeField] List<GameObject> _nullHps;
        public bool MinusHp()
        {
            
            Destroy(_hps[0]);
            _hps.RemoveAt(0);
            GameObject nullHpPrefab = Instantiate(_nullHpPrefab);
            nullHpPrefab.transform.SetParent(_hpPanel.transform, true);
            nullHpPrefab.transform.localScale = Vector3.one;
            _nullHps.Add(nullHpPrefab);
                
            if (_hps.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
