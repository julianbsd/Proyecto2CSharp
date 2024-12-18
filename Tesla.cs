﻿using Proyecto2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class Tesla
    {
        private int anio;
        private int kmActual;
        private string color;
        private string duenio;
        private int autonomia;
        private int service;
        private int asientos;

        //-------------------- Constructor --------------------
        public Tesla(int anio, int kmActual, string color, string duenio, int autonomia, int service, int asientos = 0)
        {
            this.anio = anio;
            this.kmActual = kmActual;
            this.color = color;
            this.duenio = duenio;
            this.autonomia = autonomia;
            this.service = service;
            this.asientos = asientos;
        }


        //---------------- Metodos setters y getters ----------------
        public int Anio { get => anio; }
        public int KmActual { get => kmActual; set => kmActual = value; }
        public string Color { get => color; set => color = value; }
        public string Duenio { get => duenio; set => duenio = value; }
        public int Autonomia { get => autonomia; }
        public int Service { get => service; set => service = value; }
        public int Asientos { get => asientos; }


        //--------------------- Escaneo ---------------------
        public string Escaneo()
        {
            // Cada cuantos km recorridos se hace cada control
            int kmControlCinturones = 1000;
            int kmControlBaterias = 2000;
            int kmControlSistemaNav = 2500;
            int kmControlSistemaTrac = 3000;
            int kmControlMotor = 3000;

            // Cantidad de Services
            int cantServices = kmActual / service;
            int kmServiceActual;
            string totalServices = "";

            // Guardan en que kilometraje fue el ultimo control de cada uno
            int ultimoControlCinturones = 0;
            int ultimoControlBaterias = 0;
            int ultimoControlSistemaNav = 0;
            int ultimoControlSistemaTrac = 0;
            int ultimoControlMotor = 0;

            // En cada service checkea si pasaron los km correspondientes para realizar cada control,
            // en base a las variables ultimoControl, y si es asi se agrega a la string de services que devuelve el metodo
            for (int numService = 1; numService <= cantServices; numService++)
            {
                kmServiceActual = numService * Service;
                totalServices += $"Service {numService} ({kmServiceActual}km): ";

                if (kmServiceActual >= kmControlCinturones && kmServiceActual - ultimoControlCinturones >= kmControlCinturones)
                {
                    totalServices += "(1)";
                    ultimoControlCinturones = kmServiceActual;
                }
                if (kmServiceActual >= kmControlBaterias && kmServiceActual - ultimoControlBaterias >= kmControlBaterias)
                {
                    totalServices += "(2)";
                    ultimoControlBaterias = kmServiceActual;
                }
                if (kmServiceActual >= kmControlSistemaNav && kmServiceActual - ultimoControlSistemaNav >= kmControlSistemaNav)
                {
                    totalServices += "(3)";
                    ultimoControlSistemaNav = kmServiceActual;
                }
                if (kmServiceActual >= kmControlSistemaTrac && kmServiceActual - ultimoControlSistemaTrac >= kmControlSistemaTrac)
                {
                    totalServices += "(4)";
                    ultimoControlSistemaTrac = kmServiceActual;
                }
                if (kmServiceActual >= kmControlMotor && kmServiceActual - ultimoControlMotor >= kmControlMotor)
                {
                    totalServices += "(5)";
                    ultimoControlMotor = kmServiceActual;
                }

                totalServices += "\n";
            }

            return totalServices;
        }

        //--------------------- Nivel de bateria ---------------------
        public string NivelBateria()
        {
            int bateriaUsada = kmActual % autonomia * 100 / Autonomia;
            int porcentajeBateria = 100 - bateriaUsada;

            return $"{porcentajeBateria}%";
        }
    }
    internal class ModeloX : Tesla
    {
        private int asientos;
        //-------------------- Constructor --------------------
        public ModeloX(int anio, int kmActual, string color, string duenio, int autonomia = 560, int service = 1000, int asientos = 7) : base(anio, kmActual, color, duenio, autonomia, service, asientos)
        {
            this.asientos = asientos;
        }

    }

    internal class ModeloS : Tesla
    {
        private int asientos;

        //-------------------- Constructor --------------------
        public ModeloS(int anio, int kmActual, string color, string duenio, int autonomia = 650, int service = 2000, int asientos = 5) : base(anio, kmActual, color, duenio, autonomia, service, asientos)
        {
            this.asientos = asientos;
        }

    }
    internal class Cybertruck : Tesla
    {
        private int asientos;

        //-------------------- Constructor --------------------
        public Cybertruck(int anio, int kmActual, string color, string duenio, int autonomia = 800, int service = 3000, int asientos = 6) : base(anio, kmActual, color, duenio, autonomia, service, asientos)
        {
            this.asientos = asientos;
        }

    }
}