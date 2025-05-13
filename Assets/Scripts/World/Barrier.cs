using Unity.VisualScripting;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private GameObject markerSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(markerSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
