using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpush : MonoBehaviour
{
  [SerializeField] 
  private float forceMagnitude;

  void OnControllerColliderHit(ControllerColliderHit hit)
  {
    Rigidbody rigidbody = hit.collider.attachedRigidbody;

    if(rigidbody != null)
    {
      Vector3 forceDirection = hit.transform.position - transform.position;
      forceDirection.y = 0;
      forceDirection.Normalize();

      rigidbody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse); 
    }
  }
}