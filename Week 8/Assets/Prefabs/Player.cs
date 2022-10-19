using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 6f;
    [SerializeField] private string xAxis = "LR";
    [SerializeField] private string zAxis = "UpDown";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis(xAxis);
        float dz = Input.GetAxis(zAxis);
        Vector3 direction = new Vector3(dx, 0, dz);

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
