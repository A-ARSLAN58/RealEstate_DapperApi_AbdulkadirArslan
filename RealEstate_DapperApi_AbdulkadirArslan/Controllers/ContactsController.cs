﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.ContactRepositories;

namespace RealEstate_DapperApi_AbdulkadirArslan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet("GetLast4Contact")]
        public async Task <IActionResult> GetLast4Contact()
        {
            var values = await _contactRepository.GetLast4Contact();
            return Ok(values);
        }
    }
}
