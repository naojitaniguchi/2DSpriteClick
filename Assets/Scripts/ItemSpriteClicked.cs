using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpriteClicked : MonoBehaviour
{
    public string itemDetail;
    public GameObject itemText;
    public GameObject itemManager;
    public ItemManager.ITEM_TYPE itemType;
    public GameObject Dialog;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spriteClicked()
    {
        Debug.Log(gameObject.name);
        itemText.GetComponent<Text>().text = itemDetail;
        itemManager.GetComponent<ItemManager>().selected = itemType;
        Dialog.SetActive(true);
    }
}
