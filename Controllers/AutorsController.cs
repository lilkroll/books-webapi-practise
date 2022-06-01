using books.Data.Models.ViewModels;
using books.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private AuthorsService _autorsService;

        public AutorsController(AuthorsService autorsService)
        {
            _autorsService = autorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddBook([FromBody] AuthorVM author)
        {
            _autorsService.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorsWithBooks(int id)
        {
            var response = _autorsService.GetAuthorWithBooks(id);
            return Ok(response);
        }

    }
}
