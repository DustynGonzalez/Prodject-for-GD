using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetFloat("DirX", 0);
        GetComponent<Animator>().SetFloat("DirY", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
