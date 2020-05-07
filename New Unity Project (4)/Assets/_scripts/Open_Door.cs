using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public Animator doorOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (doorOpen != null)
        {
            doorOpen.SetTrigger("open door trigger");
        }
    }
}
