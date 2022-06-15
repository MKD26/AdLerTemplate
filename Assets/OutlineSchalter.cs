using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class OutlineSchalter : MonoBehaviour
{
    public Outline[] outlinedLernelemente;

    // Start is called before the first frame update
    void Start()
    {
        OutlineToggle(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutlineToggle (bool schalter){
        foreach (Outline lernel in outlinedLernelemente)
        {
           lernel.enabled = schalter;
        }
    }
}
