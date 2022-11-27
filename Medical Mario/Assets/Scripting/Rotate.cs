using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}

//Followed tutorial for this code using https://www.youtube.com/watch?v=XgIv4fLu8zs&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U