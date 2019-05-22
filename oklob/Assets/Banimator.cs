using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banimator : MonoBehaviour
{
    private Animator _banim;

    void Start()
    {
        _banim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey((KeyCode.A)) || Input.GetKey((KeyCode.D)) || (Input.GetKey((KeyCode.W))) || (Input.GetKey((KeyCode.S)))){
            _banim.SetBool("AniL", true);
        } else {
            _banim.SetBool("AniL", false);
        }

    }
}

