using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

    //this script is on each animal prefab
    //this is triggered each time pizza hit the collision box
}
