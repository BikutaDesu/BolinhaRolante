using UnityEngine;

public class ParticleController : MonoBehaviour {
    
    private void Start() {
        Invoke("destroyParticle", 1.5f);    
    }

    private void destroyParticle(){
        Destroy(this.gameObject);
    }

}