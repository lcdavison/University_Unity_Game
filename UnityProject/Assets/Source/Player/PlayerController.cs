﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private float movement_speed = 2.0f;

    // Start is called before the first frame update
    void Start ( )
    {
        Cursor.lockState = CursorLockMode.Locked;
        ResourceManager rm = Singleton.GetResourceManager ( );

        player.EquipWeapon ( rm.LoadAsset < Weapon > ( "WeaponData/Rifle" ) );
    }

    void Update ( )
    {
        player.FireWeapon ( );
    }

    // Update is called once per frame
    void FixedUpdate ( )
    {
        Vector3 move_direction = new Vector3 ( Input.GetAxisRaw ( "Horizontal" ), 0.0f, Input.GetAxisRaw ( "Vertical" ) );

        //  Sprint if the shift key is held down
        if ( Input.GetKey ( KeyCode.LeftShift ) )
            move_direction *= ( movement_speed * 2 );
        else
            move_direction *= movement_speed;

        move_direction = transform.TransformDirection ( move_direction );

        move_direction.y = -2.0f;

        controller.Move ( move_direction * Time.deltaTime );
    }
}
