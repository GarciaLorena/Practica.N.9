using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Practica.N._9
{
   public class _13090351
    {
        string matricula;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;
        bool deleted;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return matricula; }
            set { matricula = value; }
        }


        [JsonProperty(PropertyName = "Nombre")]
        public string Dato1
        {
            get { return nombre; }
            set { nombre = value; }
        }


        [JsonProperty(PropertyName = "Apellidos")]
        public string Dato2
        {
            get { return apellido; }
            set { apellido = value; }
        }


        [JsonProperty(PropertyName = "Direccion")]
        public string Dato3
        {
            get { return direccion; }
            set { direccion = value; }
        }


        [JsonProperty(PropertyName = "Telefono")]
        public string Dato4
        {
            get { return telefono; }
            set { telefono = value; }
        }


        [JsonProperty(PropertyName = "Carrera")]
        public string Dato5
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [JsonProperty(PropertyName = "Semestre")]
        public string Dato6
        {
            get { return semestre; }
            set { semestre = value; }
        }


        [JsonProperty(PropertyName = "Correo")]
        public string Dato7
        {
            get { return correo; }
            set { correo = value; }
        }


        [JsonProperty(PropertyName = "GitHub")]
        public string Dato8
        {
            get { return github; }
            set { github = value; }
        }


        [JsonProperty(PropertyName = "deleted")]
        public bool Dato9
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
