using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeTxt;
    private float time = 0.0f;
    public GameObject card;
    
    void Start()
    {
        int[] rtans = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };

        rtans = rtans.OrderBy(item => Random.Range(-1.0f, 1.0f)).ToArray();
        
        for (int i = 0; i < 16; ++i)
        {
            GameObject newCard = Instantiate(card);
            newCard.transform.parent = GameObject.Find("Cards").transform;

            float x = (i / 4) * 1.4f - 2.1f;
            float y = (i % 4) * 1.4f - 3.0f;
            newCard.transform.position = new Vector3(x, y, 0);

            string rtanName = "rtan" + rtans[i].ToString();
            newCard.transform.Find("Front").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(rtanName);
        }
    }

    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
    }
}