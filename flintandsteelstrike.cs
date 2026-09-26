using UnityEngine;

public class FlashlightSpawner : MonoBehaviour
{
    // The key that triggers the light
    [SerializeField] private KeyCode triggerKey = KeyCode.F;
    
    // Duration before the light is destroyed
    [SerializeField] private float lightDuration = 1.0f;

    void Update()
    {
        // Detect key press
        if (Input.GetKeyDown(triggerKey))
        {
            SpawnTemporaryLight();
        }
    }

    void SpawnTemporaryLight()
    {
        // 1. Create a new empty GameObject
        GameObject lightGameObject = new GameObject("TemporaryLight");

        // 2. Make it a child of the Player so it moves with them
        lightGameObject.transform.SetParent(this.transform);
        
        // 3. Reset position relative to the player (adjust offset if needed)
        lightGameObject.transform.localPosition = Vector3.zero;

        // 4. Add the Light component and configure it
        Light lightComponent = lightGameObject.AddComponent<Light>();
        lightComponent.type = LightType.Point;
        lightComponent.range = 10.0f;
        lightComponent.intensity = 2.0f;

        // 5. Destroy the light GameObject automatically after the duration
        Destroy(lightGameObject, lightDuration);
    }
}
