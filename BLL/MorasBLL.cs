using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_2_2_2021.DAL;
using Tarea_2_2_2021.Models;

namespace Tarea_2_2_2021.BLL
{
    public class MorasBLL
    {
        public static bool Guardar(Moras mora)
        {
            if (!Existe(mora.MoraId))
                return Insertar(mora);
            else
                return Modificar(mora);
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Moras.Any(e => e.MoraId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        private static bool Insertar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Moras.Add(mora);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM MorasDetalle Where MoraId={mora.MoraId}");

                foreach (var ListadeMoras in mora.MorasDetalle)
                {
                    contexto.Entry(ListadeMoras).State = EntityState.Added;
                }
                contexto.Entry(mora).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Moras Buscar(int id)
        {
            Moras mora = new Moras();
            Contexto contexto = new Contexto();

            try
            {
                mora = contexto.Moras
                    .Where(e => e.MoraId == id)
                    .Include(e => e.MorasDetalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return mora;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //buscar la entidad que se desea eliminar
                var mora = contexto.Moras.Find(id);

                if (mora != null)
                {
                    contexto.Moras.Remove(mora);//remover la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
    }
}
