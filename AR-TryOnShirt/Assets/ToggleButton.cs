using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleButton : MonoBehaviour
{
    public Image changeThis;
    public Sprite on;
    public Sprite off;
    public Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBackground() 
    {
        if (toggle.isOn)
            changeThis.sprite = on;
        else
            changeThis.sprite = off;
    }
}
