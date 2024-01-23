using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        public CustomerController()
        {

        }

        [HttpPost]
        [Route("create-customer")]
        public async Task<IActionResult> CreateCustomer()
        {

        }

        [HttpGet]
        [Route("get-customer-list")]
        public async Task<IActionResult> GetCustomerList()
        {

        }
    }
}