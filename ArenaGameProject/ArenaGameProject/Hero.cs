﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameProject
{
    public class Hero
    {
        protected string name; //Imię bohatera
        public string Name { get { return name; } }//do zwracania imienia bohatera.

        protected int health; //Zywotność bohatera
        public int Health { get { return health; } } //pobranie żywotności

        protected int power; //jego power(mana,siła,zręczność) w zależności od klasy
        public int Power { get { return power; } } //pobranie power'u

        protected int tacticPoints; // punkty taktyki

        protected bool isAlly; //czy jest przyjacielem, czy wrogiem
        public bool _isAlly { get { return isAlly; } } // pobranie informacji 
        //o tym czy przyjaciel czy wrog

        protected bool isAI; //true jesli to bot, false jesli gracz
        public bool _isAI { get { return isAI; } } //pobranie informaczy czyBot.

        public void healthChange(bool heal, int change) // zmiana stanu zycia
        {
            if (heal) //czy leczenie
            {
                health += change; // zwiekszenie zycia o wartosc przekazana przez change

                if (health > 100) //sprawdza czy zycia nie przekroczyły 100
                    health = 100;
            }

            else //jesli nie leczenie, to zadanie obrazen
            {
                if (this is Warrior)
                {
                    if (((Warrior)this)._moreArmor)//jesli jest to wojownik i ma zwiekszony armor
                    {
                        health -= (int)(0.5 * change);//to dostaje jedynie połowę obrażen
                    }
                    else
                        health -= change;// a jesli nie ma zwiekszonego armowa, to normalnie
                }
                else
                    health -= change;//odejmuje od żyć podana jako parametr wartosc

                if (health < 0)//sprawdza czy nie nizsze niz 0
                    health = 0;
            }
        }
    }
}