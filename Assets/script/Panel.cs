using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject Page1Panel, Page2Panel, Page3Panel, Page4Panel;
    public void OpenPage1()
    {
        Page1Panel.SetActive(true);
        Page2Panel.SetActive(false);
        Page3Panel.SetActive(false);
        Page4Panel.SetActive(false);
    }

    public void OpenPage2()
    {
        Page1Panel.SetActive(false);
        Page2Panel.SetActive(true);
        Page3Panel.SetActive(false);
        Page4Panel.SetActive(false);
    }

    public void OpenPage3()
    {
        Page1Panel.SetActive(false);
        Page2Panel.SetActive(false);
        Page3Panel.SetActive(true);
        Page4Panel.SetActive(false);
    }
    public void OpenPage4()
    {
        Page1Panel.SetActive(false);
        Page2Panel.SetActive(false);
        Page3Panel.SetActive(false);
        Page4Panel.SetActive(true);
    }
}
