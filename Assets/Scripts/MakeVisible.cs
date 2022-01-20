using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisible : MonoBehaviour
{
    
    public GameObject obiekt;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
            {
                g.SetActive(false);
            }
        }
    }
    public void ActiveDeactive()
    {
        print("Dziala");
        if(obiekt.active == false)
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
            {
                g.SetActive(false);
            }
            obiekt.SetActive(true);
            
        }
        else
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
            {
                g.SetActive(false);
            }
            obiekt.SetActive(false);
        }
    }

    public void ActiveDeactive_Testowanie_Wszystkich_Okien_Aktywnych_Naraz()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
        {
            g.SetActive(true);
        }

        print("Dziala");
        if (obiekt.active == false)
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
            {
                g.SetActive(false);
            }
            obiekt.SetActive(true);

        }
        else
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Window"))
            {
                g.SetActive(false);
            }
            obiekt.SetActive(false);
        }
    }

}
