using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerbar : MonoBehaviour
{
    private Image PowerBar;
    public float CurrentPower;
    private float MaxPower = 100f;
    Collect col;
    public GameObject[] pickUp;

    // Start is called before the first frame update
    void Start()
    {
        pickUp = GameObject.FindGameObjectsWithTag("PickUp");
        PowerBar = GetComponent<Image>();
        col = FindObjectOfType<Collect>();
        
    }



    // Update is called once per frame
    void Update()
    {
     
        PowerBar.fillAmount = CurrentPower / MaxPower;
    }
}
