using AutoMapper;
using System;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            TUsuario origen = new TUsuario() { Apellido = "Ardila" };
            var destination = Mapping.Mapper.Map<AppUsuario>(origen);

            Console.WriteLine($"appUsuario {destination.Name} {destination.Apellido}");
            Console.ReadLine();
        }
    }

    //configuración de autoMapper
    //CLASE 1
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    //CLASE 2
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TUsuario, AppUsuario>();
            CreateMap<AppUsuario, TUsuario>();
            // Additional mappings here...
        }
    }
    //CLASES MODELO
    public class TUsuario
    {
        //atributo protected
        string name = "Jorge";
        //propiedades
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Apellido { get; set; }
    }
    public class AppUsuario
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
    }
}


