using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarMenuDeComeco : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void desativarMenu()
    {
        _animator.enabled = true;
        gameObject.SetActive(false);
    }
}
