using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        Rigidbody wallInstance = Instantiate(_wallPrefab);
            
        wallInstance.isKinematic = false;
    }
}
