using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
{
    public Image[] itemsImage;
    
    public PlayerInventory playerInventory;
    
    public List<ItemScriptableObjects> itemScriptableObjects = new List<ItemScriptableObjects>();
    
    public Sprite UIimage;

    
    // Start is called before the first frame update
    void Start()
    {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();

        itemScriptableObjects = playerInventory.itemsArray;

        for (int i = 0; i < itemsImage.Length; i++)
        {
            float id = playerInventory.item[i] - 1;
            
            itemsImage[i].sprite = itemScriptableObjects[(int)id ].gameObject.GetComponent<SpriteRenderer>().sprite;

           

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (itemsImage.Length == playerInventory.item.Count)
        {
             for (int i = 0; i < itemsImage.Length; i++)
            {
                float id = playerInventory.item[i] - 1;
            
                itemsImage[i].sprite = itemScriptableObjects[(int)id].gameObject.GetComponent<SpriteRenderer>().sprite;

            }
        }
        else if(itemsImage.Length > playerInventory.item.Count) {

            for (int i = 0; i < itemsImage.Length; i++)
            {

                itemsImage[i].sprite = UIimage;

                float id = playerInventory.item[i] - 1;

                itemsImage[i].sprite = itemScriptableObjects[(int)id].gameObject.GetComponent<SpriteRenderer>().sprite;

                
                
            }

        }
    }
}
