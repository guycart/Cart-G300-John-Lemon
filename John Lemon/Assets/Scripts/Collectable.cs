using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public TextMeshProUGUI countText;

    private Rigidbody rb;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if  (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

}
