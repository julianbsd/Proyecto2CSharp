using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class SpaceX
    {
        private int anio;
        private int hsVueloActual;
        private string color;
        private string empresaDuenia;
        private int service;

        //-------------------- Constructor --------------------
        public SpaceX(int anio, int hsVueloActual, string color, string empresaDuenia, int service = 0)
        {
            this.anio = anio;
            this.hsVueloActual = hsVueloActual;
            this.color = color;
            this.empresaDuenia = empresaDuenia;
            this.service = service;
        }

        //---------------- Metodos setters y getters ----------------
        public int Anio { get => anio; set => anio = value; }
        public int HsVueloActual { get => hsVueloActual; set => hsVueloActual = value; }
        public string Color { get => color; set => color = value; }
        public string EmpresaDuenia { get => empresaDuenia; set => empresaDuenia = value; }
        public int Service { get => service; }

        //--------------------- Escaneo ---------------------
        public string Escaneo()
        {
            int cantControlSistemaNav = 0;
            int cantControlSistemaProp = 0;
            double hsVuelo = hsVueloActual;

            //cantidad de Service
            double cantService = Math.Round(hsVuelo / service);

            //Control del Sistema de Propulsion: cada 1000Hs
            if (hsVuelo >= 1000)
            {
                double hsVuelo2 = hsVueloActual;
                while (hsVuelo2 >= 1000)
                {
                    cantControlSistemaProp += 1;
                    hsVuelo2 -= 1000;
                }
            }

            //Control del Sistema de Navegacion: cada 500Hs
            if (hsVuelo >= 500)
            {
                double hsVuelo2 = hsVueloActual;
                while (hsVuelo2 >= 500)
                {
                    cantControlSistemaNav += 1;
                    hsVuelo2 -= 500;
                }
            }

            return $"Se realizarion {cantService} Service:\n" +
                   $"\tControles del Sistema de Propulsion = {cantControlSistemaProp}\n" +
                   $"\tControles del Sistema de Navegacion = {cantControlSistemaNav}\n";
        }
    }
    internal class Falcon9 : SpaceX
    {
        private int autonomia;

        //-------------------- Constructor --------------------
        public Falcon9(int anio, int hsVueloActual, string color, string empresaDuenia, int autonomia = 200, int service = 400) : base(anio, hsVueloActual, color, empresaDuenia, service)
        {
            this.autonomia = autonomia;
        }

        //---------------- Metodos getters ----------------
        public int Autonomia { get => autonomia; }
    }

    internal class Starship : SpaceX
    {
        private int autonomia;

        //-------------------- Constructor --------------------
        public Starship(int anio, int hsVueloActual, string color, string empresaDuenia, int autonomia = 500, int service = 1000) : base(anio, hsVueloActual, color, empresaDuenia, service)
        {
            this.autonomia = autonomia;
        }

        //---------------- Metodos getters ----------------
        public int Autonomia { get => autonomia; }
    }

}