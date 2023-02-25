using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlocked : MonoBehaviour
{
  public GameObject door;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("coin"))
       {
        Destroy(other.gameObject);
        Destroy(door);
       } 
    }
}
