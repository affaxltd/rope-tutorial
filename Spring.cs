using UnityEngine;

public class Spring {
    private float strength;
    private float damper;
    private float target;
    private float velocity;
    private float value;

    public void Update(float deltaTime) {
        var direction = target - value >= 0 ? 1f : -1f;
        var force = Mathf.Abs(target - value) * strength;
        velocity += (force * direction - velocity * damper) * deltaTime;
        value += velocity * deltaTime;
    }

    public void Reset() {
        velocity = 0f;
        value = 0f;
    }
        
    public void SetValue(float value) {
        this.value = value;
    }
        
    public void SetTarget(float target) {
        this.target = target;
    }

    public void SetDamper(float damper) {
        this.damper = damper;
    }
        
    public void SetStrength(float strength) {
        this.strength = strength;
    }

    public void SetVelocity(float velocity) {
        this.velocity = velocity;
    }
        
    public float Value => value;
}