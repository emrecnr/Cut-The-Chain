using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    [SerializeField] private float _chainDistance = .2f;

    public Dictionary<string,HingeJoint2D> hingeControl = new Dictionary<string, HingeJoint2D>();
    public void ConnectChain(Rigidbody2D lastChain,string hingeName)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        hingeControl.Add(hingeName, joint);
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastChain;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f,-_chainDistance);
    }
}
