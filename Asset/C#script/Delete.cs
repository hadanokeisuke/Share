using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    [SerializeField] GameObject Item;
    // Start is called before the first frame update
    public void OnClick()
    {
        Item.SetActive(true);
    }

}