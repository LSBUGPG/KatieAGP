using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float powerUp;
    
    public GameObject powabar;


    // Start is called before the first frame update
    void Start()
    {
        powerUp = 0f;
        powabar.GetComponent<Powerbar>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name == "Potion")
        {
            powabar.GetComponent<Powerbar>().CurrentPower += 10f;
            GameObject.Find("Potion UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            this.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("Item");

        }
        
        if (gameObject.name == "Key")
        {
            powabar.GetComponent<Powerbar>().CurrentPower += 10f;
            GameObject.Find("Key UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            this.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("Key");

        }
        
        if (gameObject.name == "Frog")
        {
            powabar.GetComponent<Powerbar>().CurrentPower += 10f;
            GameObject.Find("Frog UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            this.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("Item");
        }
        
        
            
        
    }

}
