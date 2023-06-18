using Proyecto2;
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
        private double kmActual;
        private string color;
        private string duenio;
        private double service;

        //-------------------- Constructor --------------------
        public Tesla(int anio, double kmActual, string color, string duenio, double service = 0)
        {
            this.anio = anio;
            this.kmActual = kmActual;
            this.color = color;
            this.duenio = duenio;
            this.service = service;
        }


        //---------------- Metodos setters y getters ----------------
        public int Anio { get => anio; }
        public double KmActual { get => kmActual; set => kmActual = value; }
        public string Color { get => color; set => color = value; }
        public string Duenio { get => duenio; set => duenio = value; }
        public double Service { get => service; set => service = value; }

        //--------------------- Escaneo ---------------------
        public string Escaneo()
        {
            int cantControlCinturones = 0;
            int cantControlBaterias = 0;
            int cantControlSistemaNav = 0;
            int cantControlSistemaTrac = 0;
            int cantControlmotor = 0;
            double kilometraje = kmActual;

            //cantidad de Service
            double cantService = Math.Round(kmActual / service);

            //Control Cinturones de Seguridad: cada 1000km
            if (kilometraje >= 1000)
            {
                double kilometraje2 = kmActual;
                while (kilometraje2 >= 1000)
                {
                    cantControlCinturones += 1;
                    kilometraje2 -= 1000;
                }
            }

            //Control de Baterias: cada 2000km
            if (kilometraje >= 2000)
            {
                double kilometraje2 = kmActual;
                while (kilometraje2 >= 2000)
                {
                    cantControlBaterias += 1;
                    kilometraje2 -= 2000;
                }
            }

            //Control del Sistema de Navegacion: 2500km
            if (kilometraje >= 2500)
            {
                double kilometraje2 = kmActual;
                while (kilometraje2 >= 2500)
                {
                    cantControlSistemaNav += 1;
                    kilometraje2 -= 2500;
                }
            }

            //Control del Sistema de Traccion: cada 3000km.
            if (kilometraje >= 3000)
            {
                double kilometraje2 = kmActual;
                while (kilometraje2 >= 3000)
                {
                    cantControlSistemaTrac += 1;
                    kilometraje2 -= 3000;
                }
            }

            //Control del motor: cada 3000km.
            if (kilometraje >= 3000)
            {
                double kilometraje2 = kmActual;
                while (kilometraje2 >= 3000)
                {
                    cantControlmotor += 1;
                    kilometraje2 -= 3000;
                }
            }

            return $"Se realizarion {cantService} Service:\n" +
                   $"\tControles de Cinturones de Seguridad = {cantControlCinturones}\n" +
                   $"\tControles de Baterias = {cantControlBaterias}\n" +
                   $"\tControles del Sistema de Navegacion = {cantControlSistemaNav}\n" +
                   $"\tControles del Sistema Traccion = {cantControlSistemaTrac}\n" +
                   $"\tControles del motor = {cantControlmotor}";
        }
    }
    internal class ModeloX : Tesla
    {
        private double autonomia;
        private int asientos;
        //-------------------- Constructor --------------------
        public ModeloX(int anio, double kmActual, string color, string duenio, double autonomia = 560, int asientos = 7, double service = 1000) : base(anio, kmActual, color, duenio, service)
        {
            this.autonomia = autonomia;
            this.asientos = asientos;
        }

        //---------------- Metodos getters ----------------
        public double Autonomia { get => autonomia; }
        public int Asientos { get => asientos; }
    }

    internal class ModeloS : Tesla
    {
        private double autonomia;
        private int asientos;

        //-------------------- Constructor --------------------
        public ModeloS(int anio, double kmActual, string color, string duenio, double autonomia = 650, int asientos = 5, double service = 2000) : base(anio, kmActual, color, duenio, service)
        {
            this.autonomia = autonomia;
            this.asientos = asientos;
        }

        //---------------- Metodos getters ----------------
        public double Autonomia { get => autonomia; }
        public int Asientos { get => asientos; }

    }
    internal class Cybertruck : Tesla
    {
        private double autonomia;
        private int asientos;

        //-------------------- Constructor --------------------
        public Cybertruck(int anio, double kmActual, string color, string duenio, double autonomia = 800, int asientos = 6, double service = 3000) : base(anio, kmActual, color, duenio, service)
        {
            this.autonomia = autonomia;
            this.asientos = asientos;
        }

        //---------------- Metodos getters ----------------
        public double Autonomia { get => autonomia; }
        public int Asientos { get => asientos; }
    }
}