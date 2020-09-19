using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPF.MultipleEleven.Domain;
using NPF.MultipleEleven.Domain.Requests;

namespace NPF.MultipleEleven.Api.Controllers
{
    /// <summary>
    /// multiple eleven api controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleElevenController : ControllerBase
    {
        /// <summary>
        /// check multiple eleven enpoint
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("api/multipleeleven/check")]
        public async Task<MultipleElevenResponseDto> Check(MultipleElevenRequestDto request)
        {
            //should be injected through Dependency injection
            MultipleElevenService service = new MultipleElevenService();
            var response = service.Check(request);
            return response;
        }
    }
}