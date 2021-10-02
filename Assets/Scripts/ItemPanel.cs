using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanel : MonoBehaviour
{
    public KeyCode targetKey = KeyCode.Escape;
    public GameObject itemPanel; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(targetKey))
        {
            if( itemPanel != null)
            {
                if ( itemPanel.activeSelf)
                {
                    itemPanel.SetActive(false);
                }
                else
                {
                    itemPanel.SetActive(true);
                }
            }
        }
    }
}
