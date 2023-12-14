using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class bossManager : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public Animator BossAnimator;
    public static bossManager BossManagerCls;  
    private float attackMode;
    public bool LockOnTarget, BossIsAlive;
    private Transform target;
    public Slider HealthBar;
    public TextMeshProUGUI Health_bar_amount;
    public int Health;
    public GameObject Particle_Death;
    public float maxDistance, minDistance;

    // level 
    public int int_level;
    public TextMeshProUGUI text_level;

    public GameObject Money_object;
    public GameObject Level_object;

    public GameObject Cm_vcam_1;

    public GameObject Cm_vcam_Boss_1;
    public GameObject Cm_vcam_Boss_2;
    public GameObject Cm_vcam_Boss_3;
    public GameObject Cm_vcam_Boss_4;
    public GameObject Cm_vcam_Boss_5;
    public GameObject Cm_vcam_Boss_6;
    public GameObject Cm_vcam_Boss_7;
    public GameObject Cm_vcam_Boss_8;
    public GameObject Cm_vcam_Boss_9;
    public GameObject Cm_vcam_Boss_10;
    public GameObject Cm_vcam_Boss_11;
    public GameObject Cm_vcam_Boss_12;
    public GameObject Cm_vcam_Boss_13;
    public GameObject Cm_vcam_Boss_14;
    public GameObject Cm_vcam_Boss_15;
    public GameObject Cm_vcam_Boss_16;
    public GameObject Cm_vcam_Boss_17;
    public GameObject Cm_vcam_Boss_18;
    public GameObject Cm_vcam_Boss_19;
    public GameObject Cm_vcam_Boss_20;
    public GameObject Cm_vcam_Boss_21;
    public GameObject Cm_vcam_Boss_22;
    public GameObject Cm_vcam_Boss_23;
    public GameObject Cm_vcam_Boss_24;
    public GameObject Cm_vcam_Boss_25;
    public GameObject Cm_vcam_Boss_26;
    public GameObject Cm_vcam_Boss_27;
    public GameObject Cm_vcam_Boss_28;
    public GameObject Cm_vcam_Boss_29;
    public GameObject Cm_vcam_Boss_30;
    public GameObject Cm_vcam_Boss_31;
    public GameObject Cm_vcam_Boss_32;
    public GameObject Cm_vcam_Boss_33;
    public GameObject Cm_vcam_Boss_34;
    public GameObject Cm_vcam_Boss_35;
    public GameObject Cm_vcam_Boss_36;
    public GameObject Cm_vcam_Boss_37;
    public GameObject Cm_vcam_Boss_38;
    public GameObject Cm_vcam_Boss_39;
    public GameObject Cm_vcam_Boss_40;
    public GameObject Cm_vcam_Boss_41;
    public GameObject Cm_vcam_Boss_42;
    public GameObject Cm_vcam_Boss_43;
    public GameObject Cm_vcam_Boss_44;
    public GameObject Cm_vcam_Boss_45;
    public GameObject Cm_vcam_Boss_46;
    public GameObject Cm_vcam_Boss_47;
    public GameObject Cm_vcam_Boss_48;
    public GameObject Cm_vcam_Boss_49;
    public GameObject Cm_vcam_Boss_50;

    public int Loaded_level;
    public int end_int;

    public int Life;
    public int Dead;

    // audio
    public GameObject Kick_Sound;
    public int Music_int;

    // langugage
    public Text contry_text;
    int contry_int;
    
    void Start()
    {
        int_level = PlayerPrefs.GetInt("int_level");
        BossManagerCls = this;
        
        var enemy = GameObject.FindGameObjectsWithTag("add");

        foreach (var stickMan in enemy)
        Enemies.Add(stickMan);

        BossAnimator = GetComponent<Animator>();

        BossIsAlive = true; 

        if (int_level == 1){
        HealthBar.value = HealthBar.maxValue = Health = 35;
        }
        if (int_level == 2){
        HealthBar.value = HealthBar.maxValue = Health = 45;
        }
        if (int_level == 3){
        HealthBar.value = HealthBar.maxValue = Health = 60;
        }
        if (int_level == 4){
        HealthBar.value = HealthBar.maxValue = Health = 75;
        }
        if (int_level == 5){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 6){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 7){
        HealthBar.value = HealthBar.maxValue = Health = 115;
        }
        if (int_level == 8){
        HealthBar.value = HealthBar.maxValue = Health = 120;
        }
        if (int_level == 9){
        HealthBar.value = HealthBar.maxValue = Health = 130;
        }
        if (int_level == 10){
        HealthBar.value = HealthBar.maxValue = Health = 90;
        }
        if (int_level == 11){
        HealthBar.value = HealthBar.maxValue = Health = 125;
        }
        if (int_level == 12){
        HealthBar.value = HealthBar.maxValue = Health = 130;
        }
        if (int_level == 13){
        HealthBar.value = HealthBar.maxValue = Health = 125;
        }
        if (int_level == 14){
        HealthBar.value = HealthBar.maxValue = Health = 110;
        }
        if (int_level == 15){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 16){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 17){
        HealthBar.value = HealthBar.maxValue = Health = 95;
        }
        if (int_level == 18){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 19){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 20){
        HealthBar.value = HealthBar.maxValue = Health = 80;
        }
        if (int_level == 21){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 22){
        HealthBar.value = HealthBar.maxValue = Health = 65;
        }
        if (int_level == 23){
        HealthBar.value = HealthBar.maxValue = Health = 90;
        }
        if (int_level == 24){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 25){
        HealthBar.value = HealthBar.maxValue = Health = 80;
        }
        if (int_level == 26){
        HealthBar.value = HealthBar.maxValue = Health = 120;
        }
        if (int_level == 27){
        HealthBar.value = HealthBar.maxValue = Health = 60;
        }
        if (int_level == 28){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 29){
        HealthBar.value = HealthBar.maxValue = Health = 75;
        }
        if (int_level == 30){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 31){
        HealthBar.value = HealthBar.maxValue = Health = 80;
        }
        if (int_level == 32){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 33){
        HealthBar.value = HealthBar.maxValue = Health = 60;
        }
        if (int_level == 34){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 35){
        HealthBar.value = HealthBar.maxValue = Health = 76;
        }
        if (int_level == 36){
        HealthBar.value = HealthBar.maxValue = Health = 80;
        }
        if (int_level == 37){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 38){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 39){
        HealthBar.value = HealthBar.maxValue = Health = 80;
        }
        if (int_level == 40){
        HealthBar.value = HealthBar.maxValue = Health = 250;
        }
        if (int_level == 41){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 42){
        HealthBar.value = HealthBar.maxValue = Health = 50;
        }
        if (int_level == 43){
        HealthBar.value = HealthBar.maxValue = Health = 50;
        }
        if (int_level == 44){
        HealthBar.value = HealthBar.maxValue = Health = 50;
        }
        if (int_level == 45){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 46){
        HealthBar.value = HealthBar.maxValue = Health = 70;
        }
        if (int_level == 47){
        HealthBar.value = HealthBar.maxValue = Health = 85;
        }
        if (int_level == 48){
        HealthBar.value = HealthBar.maxValue = Health = 65;
        }
        if (int_level == 49){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }
        if (int_level == 50){
        HealthBar.value = HealthBar.maxValue = Health = 100;
        }

        Health_bar_amount.text = Health.ToString();
    }

    void Update()
    {
        Music_int = PlayerPrefs.GetInt("Music_int");
        Dead = PlayerPrefs.GetInt("Dead");
        Life = PlayerPrefs.GetInt("Life");

        int_level = PlayerPrefs.GetInt("int_level");
        end_int = PlayerPrefs.GetInt("end_int");

        HealthBar.transform.rotation = Quaternion.Euler( HealthBar.transform.rotation.x,0f, HealthBar.transform.rotation.y);

        if (Enemies.Count >= 0)
            foreach (var stickMan in Enemies)
            {
                var stickManDistance = stickMan.transform.position - transform.position;

                if (stickManDistance.sqrMagnitude < maxDistance * maxDistance && !LockOnTarget)
                {
                    if (Music_int == 0){
                    Kick_Sound.SetActive(true);
                    }
                    if (Music_int == 1){
                    Kick_Sound.SetActive(false);
                    }

                    target = stickMan.transform;
                    BossAnimator.SetBool("fight",true); // need to define.

                    transform.position = Vector3.MoveTowards(transform.position, target.position, 1f * Time.deltaTime);
                }

                if (stickManDistance.sqrMagnitude < minDistance * minDistance)
                    LockOnTarget = true;
            
            }

        if (LockOnTarget)
        {
            Money_object.SetActive(false);
            Level_object.SetActive(false);

            var bossRotation = new Vector3(target.position.x,transform.position.y,target.position.z) - transform.position;
            
            transform.rotation = Quaternion.Slerp(transform.rotation,quaternion.LookRotation(bossRotation,Vector3.up), 10f * Time.deltaTime );

            for (int i = 0; i < Enemies.Count; i++)
                if (!Enemies.ElementAt(i).GetComponent<memeberManager>().member)
                    Enemies.RemoveAt(i);
            
        }

        if (Life >= 1 && Dead >= 1){
        if (Dead >= Life){
        if (Enemies.Count == 0)
        {
            Kick_Sound.SetActive(false);
            
            BossAnimator.SetBool("fight",false);
            BossAnimator.SetFloat("attackmode",4f);
        }
        }
        }

        if (Health <= 0 && BossIsAlive)
        {
            Kick_Sound.SetActive(false);

            end_int = 1;
            PlayerPrefs.SetInt("end_int",end_int);

            Loaded_level = 2;
            PlayerPrefs.SetInt("Loaded_level",Loaded_level);

            gameObject.SetActive(false);
            BossIsAlive = false;
            Instantiate(Particle_Death, transform.position, Quaternion.identity);
        }
    }

    public void ChangeTheBossAttackMode()
    {
        BossAnimator.SetFloat("attackmode",Random.Range(2,4));

        if(Cm_vcam_1 != null){
        Cm_vcam_1.SetActive(false);
        }

        // первый уровень
        if (int_level == 1){
        Cm_vcam_Boss_1.SetActive(true);
        }

        // второй уровень
        if (int_level == 2){
        Cm_vcam_Boss_2.SetActive(true);
        }

        // третий уровень
        if (int_level == 3){
        Cm_vcam_Boss_3.SetActive(true);
        }

        // четвертый уровень
        if (int_level == 4){
        Cm_vcam_Boss_4.SetActive(true);
        }

        // пятий уровень
        if (int_level == 5){
        Cm_vcam_Boss_5.SetActive(true);
        }

        // шестой уровень
        if (int_level == 6){
        Cm_vcam_Boss_6.SetActive(true);
        }

        // седьмой уровень
        if (int_level == 7){
        Cm_vcam_Boss_7.SetActive(true);
        }

        // восьмой уровень
        if (int_level == 8){
        Cm_vcam_Boss_8.SetActive(true);
        }

        // девятый уровень
        if (int_level == 9){
        Cm_vcam_Boss_9.SetActive(true);
        }

        // десятый уровень
        if (int_level == 10){
        Cm_vcam_Boss_10.SetActive(true);
        }

        if (int_level == 11){
        Cm_vcam_Boss_11.SetActive(true);
        }

        if (int_level == 12){
        Cm_vcam_Boss_12.SetActive(true);
        }

        if (int_level == 13){
        Cm_vcam_Boss_13.SetActive(true);
        }

        if (int_level == 14){
        Cm_vcam_Boss_14.SetActive(true);
        }

        if (int_level == 15){
        Cm_vcam_Boss_15.SetActive(true);
        }

        if (int_level == 16){
        Cm_vcam_Boss_16.SetActive(true);
        }

        if (int_level == 17){
        Cm_vcam_Boss_17.SetActive(true);
        }

        if (int_level == 18){
        Cm_vcam_Boss_18.SetActive(true);
        }

        if (int_level == 19){
        Cm_vcam_Boss_19.SetActive(true);
        }

        if (int_level == 20){
        Cm_vcam_Boss_20.SetActive(true);
        }

        if (int_level == 21){
        Cm_vcam_Boss_21.SetActive(true);
        }

        if (int_level == 22){
        Cm_vcam_Boss_22.SetActive(true);
        }

        if (int_level == 23){
        Cm_vcam_Boss_23.SetActive(true);
        }

        if (int_level == 24){
        Cm_vcam_Boss_24.SetActive(true);
        }

        if (int_level == 25){
        Cm_vcam_Boss_25.SetActive(true);
        }

        if (int_level == 26){
        Cm_vcam_Boss_26.SetActive(true);
        }

        if (int_level == 27){
        Cm_vcam_Boss_27.SetActive(true);
        }

        if (int_level == 28){
        Cm_vcam_Boss_28.SetActive(true);
        }

        if (int_level == 29){
        Cm_vcam_Boss_29.SetActive(true);
        }

        if (int_level == 30){
        Cm_vcam_Boss_30.SetActive(true);
        }

        if (int_level == 31){
        Cm_vcam_Boss_31.SetActive(true);
        }

        if (int_level == 32){
        Cm_vcam_Boss_32.SetActive(true);
        }

        if (int_level == 33){
        Cm_vcam_Boss_33.SetActive(true);
        }

        if (int_level == 34){
        Cm_vcam_Boss_34.SetActive(true);
        }

        if (int_level == 35){
        Cm_vcam_Boss_35.SetActive(true);
        }

        if (int_level == 36){
        Cm_vcam_Boss_36.SetActive(true);
        }

        if (int_level == 37){
        Cm_vcam_Boss_37.SetActive(true);
        }

        if (int_level == 38){
        Cm_vcam_Boss_38.SetActive(true);
        }

        if (int_level == 39){
        Cm_vcam_Boss_39.SetActive(true);
        }

        if (int_level == 40){
        Cm_vcam_Boss_40.SetActive(true);
        }

        if (int_level == 41){
        Cm_vcam_Boss_41.SetActive(true);
        }

        if (int_level == 42){
        Cm_vcam_Boss_42.SetActive(true);
        }

        if (int_level == 43){
        Cm_vcam_Boss_43.SetActive(true);
        }

        if (int_level == 44){
        Cm_vcam_Boss_44.SetActive(true);
        }

        if (int_level == 45){
        Cm_vcam_Boss_45.SetActive(true);
        }

        if (int_level == 46){
        Cm_vcam_Boss_46.SetActive(true);
        }

        if (int_level == 47){
        Cm_vcam_Boss_47.SetActive(true);
        }

        if (int_level == 48){
        Cm_vcam_Boss_48.SetActive(true);
        }

        if (int_level == 49){
        Cm_vcam_Boss_49.SetActive(true);
        }

        if (int_level == 50){
        Cm_vcam_Boss_50.SetActive(true);
        }
    }
}
