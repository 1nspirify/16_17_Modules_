using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<IInteractable>()?.Interact();
    }
}

    


