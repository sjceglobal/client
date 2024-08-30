using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 500f;
	const float backgroundPositionY = 240;
	const float backgroundOutPositionX = -1280;
	const float backgroundStartPositionX = 3837;

	public Image[] backgroundSprite;
	float[] backgroundOffset;

    // Use this for initialization
	void Start ()
    {
		InitBackgroundSpritePosition ();
	}

	// Update is called once per frame
	void Update ()
    {
		MoveBackgroundSpritePosition ();  
	}

	void InitBackgroundSpritePosition()
	{
		backgroundOffset = new float[backgroundSprite.Length];

		for(int i = 0; i < backgroundSprite.Length; ++i)
		{
			backgroundOffset[i] = backgroundSprite[i].transform.localPosition.x;

		}
	}

	void MoveBackgroundSpritePosition()
	{
		for (int i = 0; i < backgroundSprite.Length; ++i) {
			backgroundOffset[i] -= Time.deltaTime * scrollSpeed;
			backgroundSprite[i].transform.localPosition = new Vector3(backgroundOffset[i], backgroundPositionY);

			if (backgroundSprite[i].transform.localPosition.x <= backgroundOutPositionX)
			{
				backgroundSprite[i].transform.localPosition = new Vector3(backgroundStartPositionX, backgroundPositionY);
				backgroundOffset[i] = backgroundSprite[i].transform.localPosition.x;

			}
		}
	}
}
