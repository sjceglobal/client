using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image rawImage;

    float fades = 0.0f;
    float time = 0.0f;
    const float fadesReference = 0.02f;
    public float timeReference = 0.07f;

    bool isFadeIn = true;
    bool isFadeOut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        // fade in
        if(isFadeIn && time >= timeReference)
        {
            fades += fadesReference;
            rawImage.color = new Color(1, 1, 1, fades);
            time = 0.0f;

            if(fades >= 1.0f)
            {
                isFadeIn = false;
                isFadeOut = true;
            }
        }
        // fade out
        else if(isFadeOut && time >= timeReference)
        {
            fades -= fadesReference;
            rawImage.color = new Color(1, 1, 1, fades);
            time = 0.0f;

            if (fades <= 0.0f)
            {
                isFadeOut = false;
            }
        }
        else if(!isFadeIn && !isFadeOut)
        {
            Debug.Log(rawImage.name + " >> fade In Out end");
            this.gameObject.SetActive(false);
        }
    }
}
