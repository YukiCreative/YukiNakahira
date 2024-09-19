using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LopeController : InteractableObjects
{
    private bool m_playerIsAttached = false;
    private Rigidbody2D m_playerRigidbody;
    private Rigidbody2D m_rigidbody;
    private DistanceJoint2D m_distanceJoint;

    protected override void Start()
    {
        base.Start();
        m_playerRigidbody = m_player.GetComponent<Rigidbody2D>();
        m_distanceJoint = m_player.GetComponent<DistanceJoint2D>();
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    protected override void Interact()
    {
        // 一回のみ
        if (!m_playerIsAttached)
        {
            // DistanceJointを設定
            m_playerRigidbody.simulated = false;
        }
    }

    protected override void DisInteract()
    {
        Debug.Log("出てる？");

    }
}
