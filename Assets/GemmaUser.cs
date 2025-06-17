// Example usage in another script
using UnityEngine;

namespace GemmaCpp
{
    public class TestGemma : MonoBehaviour
    {
        async void Start()
        {
            var gemma = FindObjectOfType<GemmaManager>();
            if (gemma == null)
            {
                Debug.LogError("GemmaManager not found!");
                return;
            }

            //var response = await gemma.GenerateTextAsync("Tell me a joke.");
            //Debug.Log("Gemma Response: " + response);
        }
    }

}
