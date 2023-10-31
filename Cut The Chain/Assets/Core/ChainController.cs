using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChainController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _firstHook;
    [SerializeField] Balls _balls;

    [SerializeField] private int _connectCount = 5;
    [SerializeField] private string _hingeName; 


    [SerializeField] private GameObject[] _connectPool;
    private void Start()
    {
        CreateChain();
    }
    private void CreateChain()
    {
        Rigidbody2D lastHook = _firstHook;
        for (int i = 0; i < _connectCount; i++)
        {
            _connectPool[i].SetActive(true);
            HingeJoint2D joint = _connectPool[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = lastHook;
            
            if (i < _connectCount -1)
            {
                lastHook = _connectPool[i].GetComponent<Rigidbody2D>();

            }
            else
            {
                _balls.ConnectChain(_connectPool[i].GetComponent<Rigidbody2D>(), _hingeName);
            }
        }
    }
}
