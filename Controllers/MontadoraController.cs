using Microsoft.AspNetCore.Mvc;
using NET_GraphQL_API.Repositories;
using NET_GraphQL_API.Models;

namespace NET_GraphQL_API.Controllers
{
    public class MontadoraController : ControllerBase
    {
        private readonly IMontadoraRepository _montadoraRepository;

        public MontadoraController(IMontadoraRepository montadoraRepository)
        {
            _montadoraRepository = montadoraRepository;
        }

        [HttpGet("~/Montadoras")]
        public IEnumerable<Montadora> GetMontadoras()
        {
            return _montadoraRepository.GetMontadoras();
        }

        [HttpGet("~/MontadoraById")]
        public Montadora GetMontadoraById(int montadoraId)
        {
            return _montadoraRepository.GetMontadoraById(montadoraId);
        }
    }
}
