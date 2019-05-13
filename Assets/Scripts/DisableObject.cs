using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableObject : MonoBehaviour
{
    public GameObject Note;
    public bool Activate;

    void Update()
    {
        if(Activate == false)
        {
            Note.SetActive (true);
        }
        else
        {
            Note.SetActive (false);
        }
    }
}
