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
        private int autonomia;
        private int service;

        //-------------------- Constructor --------------------
        public SpaceX(int anio, int hsVueloActual, string color, string empresaDuenia, int autonomia, int service)
        {
            this.anio = anio;
            this.hsVueloActual = hsVueloActual;
            this.color = color;
            this.empresaDuenia = empresaDuenia;
            this.autonomia = autonomia;
            this.service = service;
        }

        //---------------- Metodos setters y getters ----------------
        public int Anio { get => anio; set => anio = value; }
        public int HsVueloActual { get => hsVueloActual; set => hsVueloActual = value; }
        public string Color { get => color; set => color = value; }
        public string EmpresaDuenia { get => empresaDuenia; set => empresaDuenia = value; }
        public int Autonomia { get => autonomia; }
        public int Service { get => service; }

        //--------------------- Escaneo ---------------------
        public string Escaneo()
        {
            // Cada cuantas hs de vuelo se hace cada control
            int kmControlSistemaNav = 500;
            int kmControlSistemaProp = 1000;

            // Cantidad de Services
            int cantServices = hsVueloActual / service;
            int hsServiceActual;
            string totalServices = "";

            // Guardan en que hs fue el ultimo control de cada uno
            int ultimoControlSistemaNav = 0;
            int ultimoControlSistemaProp = 0;

            // En cada service checkea si pasaron las hs correspondientes para realizar cada control,
            // en base a las variables ultimoControl, y si es asi se agrega a la string de services que devuelve el metodo
            for (int numService = 1; numService <= cantServices; numService++)
            {
                hsServiceActual = numService * Service;
                totalServices += $"Service {numService} ({hsServiceActual}hs): ";

                if (hsServiceActual >= kmControlSistemaNav && hsServiceActual - ultimoControlSistemaNav >= kmControlSistemaNav)
                {
                    totalServices += "(1)";
                    ultimoControlSistemaNav = hsServiceActual;
                }

                if (hsServiceActual >= kmControlSistemaProp && hsServiceActual - ultimoControlSistemaProp >= kmControlSistemaProp)
                {
                    totalServices += "(2)";
                    ultimoControlSistemaProp = hsServiceActual;
                }

                totalServices +=  "\n";
            }

            return totalServices;
        }

        //--------------------- Nivel de combustible ---------------------
        public string NivelCombustible()
        {
            int combustibleUsado = hsVueloActual % autonomia * 100 / Autonomia;
            int porcentajeCombustible = 100 - combustibleUsado;

            return $"{porcentajeCombustible}%";
        }
    }
    internal class Falcon9 : SpaceX
    {
        private int autonomia;

        //-------------------- Constructor --------------------
        public Falcon9(int anio, int hsVueloActual, string color, string empresaDuenia, int autonomia = 200, int service = 400) : base(anio, hsVueloActual, color, empresaDuenia, autonomia, service)
        {
            this.autonomia = autonomia;
        }
    }

    internal class Starship : SpaceX
    {
        private int autonomia;

        //-------------------- Constructor --------------------
        public Starship(int anio, int hsVueloActual, string color, string empresaDuenia, int autonomia = 500, int service = 1000) : base(anio, hsVueloActual, color, empresaDuenia, autonomia, service)
        {
            this.autonomia = autonomia;
        }
    }

}