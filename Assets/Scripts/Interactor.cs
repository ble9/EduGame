// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Interactor : MonoBehaviour
// {
//    public Transform InteractorSource;
//    public float InteractRange;
//     void Start()
//     {
        
//     }
//     // 

//     // Update is called once per frame
//     void Update()
//     {
//          if( Input.GetKeyDown(KeyCode.F)){
//             Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
//             if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) {
//                 if(hitInfo.collider.gameObject.TryGetComponent(out Interact interactObj)){
//                     interactObj.Interact();
//                 }
//             }
//          }
//     }
// }
