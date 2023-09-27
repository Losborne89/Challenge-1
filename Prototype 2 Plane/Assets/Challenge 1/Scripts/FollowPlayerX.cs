using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    private Vector3 offset = new Vector3(50, 0, 5);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //camera position relative to player
        transform.position = player.transform.position + offset;
    }
}
