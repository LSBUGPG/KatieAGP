using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite candleSprite, litSprite;
    public GameObject powabar;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        candleSprite = Resources.Load<Sprite>("Candle");
        litSprite = Resources.Load<Sprite>("Lit");
        rend.sprite = candleSprite;
    }

    // Update is called once per frame
    private void Update()
    {

    }
        void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            if (gameObject.name == "Candle")
            {
                if (rend.sprite == candleSprite)
                    rend.sprite = litSprite;
                powabar.GetComponent<Powerbar>().CurrentPower += 10f;
                FindObjectOfType<AudioManager>().Play("Lit");

            }
        }
    }
}
