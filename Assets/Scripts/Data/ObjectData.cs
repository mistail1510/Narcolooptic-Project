using UnityEngine;
using UnityEngine.UIElements;

namespace Data
{
    [CreateAssetMenu(fileName = "Object_SO", menuName = "Scriptable Objects/Object")]
    public class ObjectData : ScriptableObject
    {
        [SerializeField] public bool isKey;
        
        [SerializeField] public bool isUsed;

        [SerializeField] public Sprite objImage;
        
        [SerializeField] public AudioClip AudioPickup;
    }
}
