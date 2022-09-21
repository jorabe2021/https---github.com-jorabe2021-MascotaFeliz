using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;



namespace MascotaFeliz.App.Consola
{
    class Program
    { 
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddDueno();
            //BuscarDueno(1);
            //ListarDuenos();
            //EliminarDueno(1);
            //ListarDuenoFiltro();
            //EditarDueno(3);
            
            //AddMascota();
            //BuscarMascota(1);
            //ListarMascotas();
            //EliminarMascota(1);
            //ListarMascotaFiltro();
            //EditarMascota(2);

            //AddVeterinario();
            //BuscarVeterinario(2);
            //ListarVeterinarios();
            //EliminarVeterinario(2);
            //ListarVeterinarioFiltro();
            //EditarVeterinario(6);

            //AddHistoria();

            //AddVisitaPyP();
            //BuscarVisitaPyP(1);
            //ListarVisitaPyP();
            //EliminarVisitaPyP(1);
            //EditarVisitaPyP(1);
            
        }

        //Agregar Dueño
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombre = "Eli",
                Apellidos = "hernandez",
                Direccion = "Barrancabermeja",
                Telefono = "02312230",
                Correo = "elprofe@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        //Buscar Dueño
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombre +" "+ dueno.Apellidos);
        }

        //Listar Dueños
        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombre);
            }
        }

        //Eliminar Dueño
        private static void EliminarDueno(int idDueno)
        {
            _repoDueno.DeleteDueno(idDueno);
            Console.WriteLine("Dieño eliminado");
        }

        //Filtar Dueño por texto
        private static void ListarDuenoFiltro()
        {
            var duenos = _repoDueno.GetDuenosPorFiltro("El");
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombre +" "+ d.Apellidos);
            }
        }

        //Editar Dueño
        private static void EditarDueno(int idDueno)
        {
            var duenoEncontrado = _repoDueno.GetDueno(idDueno);
            if (duenoEncontrado != null)
            {
                duenoEncontrado.Nombre = "Pedro";
                duenoEncontrado.Apellidos = "camote";
                duenoEncontrado.Direccion = "Cl c # b - m";
                duenoEncontrado.Telefono = "5555555560";
                duenoEncontrado.Correo = "camoteo@gmail.com";
            }
            _repoDueno.UpdateDueno(duenoEncontrado);
        }

        //Agregar Mascota
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Michi",
                Color = "black",
                Especie = "feo",
                Raza = "Persa",
            };
            _repoMascota.AddMascota(mascota);
        }

        //Buscar Mascota
        private static void BuscarMascota(int idMascota)
        {
            var mascota =  _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " "+ mascota.Raza);
        }

        //Listar Mascota
        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }

        //Eliminar Mascota
        private static void EliminarMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Mascota eliminada");
        }

        //Filtrar Mascota por texto
        private static void ListarMascotaFiltro()
        {
            var mascotas = _repoMascota.GetMascotasPorFiltro("Misi");
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }
        //Editar Mascota
        private static void EditarMascota(int idMascota)
        {
            var mascotaEncontrado = _repoMascota.GetMascota(idMascota);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = "Pepita";
                mascotaEncontrado.Color = "blue";
                mascotaEncontrado.Especie = "pez";
                mascotaEncontrado.Raza = "Pez morado";
            }
            _repoMascota.UpdateMascota(mascotaEncontrado);
        }

        //Agregar Veterinario
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombre = "juan",
                Apellidos = "Vasquez",
                Direccion = "mordor",
                Telefono = "33333338",
                TarjetaProfesional = "002334"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        //Buscar Veterinario
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario =  _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombre +" "+ veterinario.TarjetaProfesional);
        }

        //Listar Veterinario
        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombre);
            }
        }

        //Eliminar Veterinario
        private static void EliminarVeterinario(int idVeterinario)
        {
            _repoVeterinario.DeleteVeterinario(idVeterinario);
            Console.WriteLine("Veterinario elminado");
        }

        //Filtrar Veterinario por texto
        private static void ListarVeterinarioFiltro()
        {
            var veterinarios = _repoVeterinario.GetVeterinariosPorFiltro("Javier");
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombre +" "+ v.Apellidos);
            }
        }
        //Editar Veterinario
        private static void EditarVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombre = "Pedro";
                veterinarioEncontrado.Apellidos = "Amayaa";
                veterinarioEncontrado.Direccion = "medellin";
                veterinarioEncontrado.Telefono = "5555555";
                veterinarioEncontrado.TarjetaProfesional = "GHM789";
            }
            _repoVeterinario.UpdateVeterinario(veterinarioEncontrado);
        }

   


      private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón",  Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón",  Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }
        //Agregar Historia
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020,09,16)
            };
            _repoHistoria.AddHistoria(historia);
        }
        
        //Agregar VisitaPyP
        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP

            {
                FechaVisita= new DateTime(2022,09,15),
                Temperatura= 37.2F,
                Peso =55.3F,
                FrecuenciaRespiratoria=33.2F,
                FrecuenciaCardiaca=80.5F,
                EstadoAnimo="Alegre",
                Recomendaciones="Reposo en casa",

            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }
        //Buscar VisitaPyP
        private static void BuscarVisitaPyP(int idVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            Console.WriteLine(visitaPyP.Id +" "+ visitaPyP.FechaVisita);
        }
        //Listar VisitaPyP
        private static void ListarVisitaPyP()
        {
            var visitaPyP = _repoVisitaPyP.GetAllVisitasPyP();
            foreach (VisitaPyP v in visitaPyP)
            {
                Console.WriteLine(v.FechaVisita);
            }
        }
         //Eliminar VisitaPyP
        private static void EliminarVisitaPyP(int idVisitaPyP)
        {
            _repoVisitaPyP.DeleteVisitaPyP(idVisitaPyP);
            Console.WriteLine("VisitaPyP eliminada");
        }
        //Editar VisitaPyP
        private static void EditarVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrado = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            if (visitaPyPEncontrado != null)
        {
                visitaPyPEncontrado.FechaVisita = new DateTime(2022,09,16);
                visitaPyPEncontrado.Temperatura = 20.5F;
                visitaPyPEncontrado.Peso = 30.3F;
                visitaPyPEncontrado.FrecuenciaRespiratoria = 50.2F;
                visitaPyPEncontrado.FrecuenciaCardiaca = 15.5F;
                visitaPyPEncontrado.EstadoAnimo= "Triste";
                visitaPyPEncontrado.Recomendaciones= "Vacaciones";
            }
            _repoVisitaPyP.UpdateVisitaPyP(visitaPyPEncontrado);
        }
    }  
}      

 //private static void EditarVisitaPyP(Id idHistoria)
       // {
            //var historia = _repoHistoria.AddHistoria(Id , Historia);
            //if (historia != null)