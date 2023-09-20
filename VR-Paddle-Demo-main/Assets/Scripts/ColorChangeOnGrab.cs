using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorChangeOnGrab : MonoBehaviour
{

    Color defaultColor;
    private void OnEnable()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
        GetComponent<XRGrabInteractable>().selectExited.AddListener(OnDrop);

        GetComponent<XRGrabInteractable>().activated.AddListener(OnAction);
        GetComponent<XRGrabInteractable>().deactivated.AddListener(OnDeaction);

        defaultColor = GetComponent<MeshRenderer>().material.color;
    }

    private void OnDisable()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
        GetComponent<XRGrabInteractable>().selectExited.AddListener(OnDrop);

        GetComponent<XRGrabInteractable>().activated.AddListener(OnAction);
        GetComponent<XRGrabInteractable>().deactivated.AddListener(OnDeaction);
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    private void OnDrop(SelectExitEventArgs arg0)
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }

    private void OnAction(ActivateEventArgs arg0)
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnDeaction(DeactivateEventArgs arg0)
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }

}
