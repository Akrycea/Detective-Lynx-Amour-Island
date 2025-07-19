using Unity.VisualScripting;
using UnityEngine;

public class Word : MonoBehaviour
{
    public Sentence sentenceScript;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        sentenceScript.sentence.Add(gameObject.name);
        Debug.Log("Added word '" + gameObject.name + "'");
    }
}
