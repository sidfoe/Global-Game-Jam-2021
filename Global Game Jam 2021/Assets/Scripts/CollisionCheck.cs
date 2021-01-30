using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public bool nearPickUp = false;
    public string itemTag;
    public GameObject colObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("PickUp") || col.gameObject.CompareTag("Eye"))
        {
            nearPickUp = true;
            itemTag = col.gameObject.tag;
            colObject = col.gameObject;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("PickUp") || col.gameObject.CompareTag("Eye"))
        {
            nearPickUp = false;
        }
    }
}
