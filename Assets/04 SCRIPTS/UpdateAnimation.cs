using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerState = PlayerController.PlayerState;

public class UpdateAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator _anim;
    void Start()
    {
        _anim = this.GetComponent<Animator>();
        
    }

    public void UpdateAnimationState(PlayerState state)
    {
        for(int i = 0; i <=(int)PlayerState.jump; i++)
        {
            string nameState = ((PlayerState)i).ToString();
            if (state.Equals((PlayerState)i))
            {
                _anim.SetBool(nameState, true);
            }
            else _anim.SetBool(nameState, false);
        }
    }
}
