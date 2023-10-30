using Microsoft.AspNetCore.Mvc;
using NET_GraphQL_API.Models;
using NET_GraphQL_API.Repositories;

namespace NET_GraphQL_API.Controllers
{
    public class CarroController : Controller
    {
        private readonly ICarroRepository _carroRepository;

        public CarroController(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        [HttpGet("~/Carros")]
        public IEnumerable<Carro> GetCarros()
        {
            return _carroRepository.GetCarros();
        }

        [HttpGet("~/CarroById")]
        public Carro GetMontadoraById(int carroId)
        {
            return _carroRepository.GetCarroById(carroId);
        }

        [HttpGet("~/CarrosByMontadora")]
        public IEnumerable<Carro> GetEmployeesByDeprtment(int montadoraId)
        {
            return _carroRepository.GetCarrosByMontadora(montadoraId);
        }
    }
}
