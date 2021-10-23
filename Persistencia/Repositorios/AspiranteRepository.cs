using Dominio;
using Persistencia.Interfaces;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data;

namespace Repositorio.Persistencia
{
    public class AspiranteRepository : IAspiranteoRepository
    {

        // DbContext
        private readonly ApplicationContext _appContext;


        /**
         *  Inyectamos el contexto a nuestro repositorio
         *  Usando la interfaz
         */
        public AspiranteRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        // Metodo para insertar un usuario
        public async Task<int> Insert(Aspirante aspirante)
        {
            try
            {

                var new_persona = _appContext.Aspirantes.Add(aspirante);
                _appContext.SaveChanges();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Error al guardar un aspirante de la casa de hechicería)");
            }

            return 0;
        
        }


        // metodo para eliminar por un id
        public async Task<int> DeleteById(int Id)
        {
            try
            {
                var PersonaEncontrada = _appContext.Aspirantes.FirstOrDefault(
                     p => p.AspiranteId == Id
                        );

                if (PersonaEncontrada == null)
                    throw new Exception("No se encontro la persona");
                _appContext.Remove(PersonaEncontrada);
                _appContext.SaveChanges();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 1;

        }

        // Actualizamos un usuario
        public async Task<Aspirante> Update(Aspirante aspirante)
        {
            try
            {
                var PersonaEncontrada = _appContext.Aspirantes.FirstOrDefault(
               p => p.AspiranteId == aspirante.AspiranteId
           );

                if (PersonaEncontrada != null)
                {
                    PersonaEncontrada.Nombre = aspirante.Nombre;
                    PersonaEncontrada.Apellido = aspirante.Apellido;
                    PersonaEncontrada.Edad = aspirante.Edad;
                    PersonaEncontrada.Identificacion = aspirante.Identificacion;
                   // PersonaEncontrada.Casa = aspirante.Casa;
                    _appContext.SaveChanges();
                }
                return PersonaEncontrada;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            throw new Exception("No se pudo actualizar el aspirante de la casa de hechiceria");
        }


        /**
         * Devolvemos todos los usuarios
         * creados en la base de datos 
         */
        public async Task<IEnumerable<Aspirante>> GetAspirantes()
        {
            var aspirantes = await _appContext.Aspirantes.ToListAsync();
            return aspirantes;
        }
    }
}
