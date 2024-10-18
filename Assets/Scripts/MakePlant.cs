using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MakePlant : MonoBehaviour
{
    public Button redButton, greenButton, blueButton;

    void Start()
    {
        redButton.onClick.AddListener(MakeRed);
        greenButton.onClick.AddListener(MakeGreen);
        blueButton.onClick.AddListener(MakeBlue);

        foreach (Transform child in transform)
        {
            Debug.Log("Found child: " + child.name);
        }
    }
    public void MakeRed()
    {
        MakePlantColor(Color.red);

    }

    public void MakeGreen()
    {
        MakePlantColor(Color.green);
    }

    public void MakeBlue()
    {
        MakePlantColor(Color.blue);
    }

    void MakePlantColor(Color color)
    {
        // find child by the name "Plant"
        Transform plant = transform.Find("Plant");
        Debug.Log(transform.Find("Plant"));
        // change the color of the plant
        plant.GetComponent<Renderer>().material.color = color;
        // set the plant to be active
        plant.gameObject.SetActive(true);

    }
}
