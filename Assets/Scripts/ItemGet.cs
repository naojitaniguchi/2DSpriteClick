using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    public GameObject dialog;
    public GameObject itemManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void buttonPushed()
    {
        dialog.SetActive(false);
        
        itemManager.GetComponent<ItemManager>().getItem();
    }
}
