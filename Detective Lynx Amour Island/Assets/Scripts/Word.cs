using Unity.VisualScripting;
using UnityEngine;

public class Word : MonoBehaviour
{
    public Sentence sentence;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        sentence.sentence.Add(gameObject.name);
        Debug.Log("Added word '" + gameObject.name + "'");
    }
}
