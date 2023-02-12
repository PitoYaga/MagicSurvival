using UnityEngine;

namespace Skills
{
    public class Thunder : MonoBehaviour
    {
        //private Animator _animator;

        private void Awake()
        {
            //_animator = GetComponent<Animator>();
        }

        void Start()
        {
            //play anim
            Destroy(gameObject,1);
        }
        
        void Update()
        {
        
        }
    }
}
