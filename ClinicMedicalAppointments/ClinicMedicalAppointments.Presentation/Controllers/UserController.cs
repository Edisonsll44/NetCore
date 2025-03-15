using ClinicMedicalAppointments.Presentation.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicMedicalAppointments.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;

        public UserController(IMediator mediator, ILogger<UserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // Obtener usuarios por estado
        [HttpGet("{status:bool}")]
        public async Task<IActionResult> GetUsersByStatus(bool status)
        {
            var query = new QueryUserRequest().ToApplicationRequest(status);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // Crear usuario
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var response = request.ToApplicationRequest();
            var result = await _mediator.Send(response);
            return Ok(result);
        }

        // Actualizar usuario
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request)
        {
            var response = request.ToApplicationRequest();
            var result = await _mediator.Send(response);
            return Ok(result);
        }

        // Desactivar usuario (Mejorado con Body en lugar de solo ID)
        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> DeactivateUser(Guid id, [FromBody] PatchUserRequest request)
        {
            var response = request.ToApplicationRequest();
            var result = await _mediator.Send(response);
            return Ok(result);
        }
    }
}