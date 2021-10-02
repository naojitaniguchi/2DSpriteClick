using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum ITEM_TYPE
    {
        SUSHI_TORO = 0,
        SUSHI_EBI = 1,
        SUSHI_IKA = 2,
        NONE = 3,
    }

    public GameObject[] items;
    public GameObject[] itemImages;

    public bool[] gotItems;

    public ITEM_TYPE selected = ITEM_TYPE.NONE;

    // Start is called before the first frame update
    void Start()
    {
        gotItems = new bool[(int)ITEM_TYPE.NONE];
        for (int i = 0; i < gotItems.Length; i ++)
        {
            gotItems[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getItem()
    {
        if ( (int)selected < items.Length)
        {
            items[(int)selected].SetActive(false);
        }

        gotItems[(int)selected] = true;
        itemImages[(int)selected].SetActive(true);

        selected = ITEM_TYPE.NONE;
    }
}
