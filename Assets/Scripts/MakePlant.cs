using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MakePlant : MonoBehaviour
{
    public void MakeRed()
    {
        Debug.Log("Red");
    }

    public void MakeGreen()
    {
        Debug.Log("Green");
    }

    public void MakeBlue()
    {
        Debug.Log("Blue");
    }

    void OnButtonClick()
    {
        Debug.Log("click");
    }
}
