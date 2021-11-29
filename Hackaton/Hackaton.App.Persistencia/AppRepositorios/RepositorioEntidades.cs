using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidades
    {      
        private readonly AppContext _appContext = new AppContext();
        public IEnumerable<Entidad> GetAll()
        {            
            return _appContext.Entidades;// retorna la informacion que se encuentra en Entidad(base de datos)
        }
        public Entidad GetEntidadWithId(int id)
        {          
           return _appContext.Entidades.Find(id); 
        }       
        public Entidad Create(Entidad newEntidad)
        { 
            var addEntidad = _appContext.Entidades.Add(newEntidad);
            _appContext.SaveChanges();
            return addEntidad.Entity;
        }
        public Entidad Update(Entidad newEntidad)
        {
            var entidad = _appContext.Entidades.Find(newEntidad.id);
            if(entidad != null)
            {
                entidad.razon_social = newEntidad.razon_social;
                entidad.nit = newEntidad.nit;
                entidad.direccion = newEntidad.direccion;
                entidad.ciudad = newEntidad.ciudad;
                entidad.telefono = newEntidad.telefono;
                entidad.email = newEntidad.email;
                entidad.webpage = newEntidad.webpage;
                entidad.sector = newEntidad.sector;
                entidad.servicio = newEntidad.servicio;
                             
                _appContext.SaveChanges(); //Guarda en base de Datos
            }
        return entidad;
        }

        public void Delete(int id)
        {
            
        var entidad = _appContext.Entidades.Find(id);
        if (entidad == null)
            return;
        _appContext.Entidades.Remove(entidad);
        _appContext.SaveChanges();
        }
    }
}