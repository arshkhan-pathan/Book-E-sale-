using BookStore.Models.DataModels;
using BookStore.Models.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("publisher")]
    public class PublisherController : ControllerBase
    {
        PublisherRepository _publisherRepository = new PublisherRepository();

        [Route("list")]
        [HttpGet]
        [ProducesResponseType(typeof(ListResponse<PublisherModel>), (int)HttpStatusCode.OK)]
        public IActionResult GetCatogires(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var publishers = _publisherRepository.GetPublishers(pageIndex, pageSize, keyword);
            ListResponse<PublisherModel> listResponse = new ListResponse<PublisherModel>()
            {
                Results = publishers.Results.Select(c => new PublisherModel(c)),
                TotalRecords = publishers.TotalRecords,
            };

            return Ok(listResponse);
        }

        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(PublisherModel), (int)HttpStatusCode.OK)]
        public IActionResult GetPublisher(int id)
        {
            var publisher = _publisherRepository.GetPublisher(id);
            PublisherModel publisherModel = new PublisherModel(publisher);

            return Ok(publisherModel);
        }

        [Route("add")]
        [HttpPost]
        [ProducesResponseType(typeof(PublisherModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]
        public IActionResult AddPublisher(PublisherModel model)
        {
            if (model == null)
                return BadRequest("Model is null");

            Publisher publisher = new Publisher()
            {
                Id = model.Id,
                Name = model.Name
            };
            var response = _publisherRepository.AddPublisher(publisher);
            PublisherModel publisherModel = new PublisherModel(response);

            return Ok(publisherModel);
        }

        [Route("update")]
        [HttpPut]
        [ProducesResponseType(typeof(PublisherModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]
        public IActionResult UpdatePublisher(PublisherModel model)
        {
            if (model == null)
                return BadRequest("Model is null");

            Publisher publisher = new Publisher()
            {
                Id = model.Id,
                Name = model.Name
            };

            var response = _publisherRepository.UpdatePublisher(publisher);
            PublisherModel publisherModel = new PublisherModel(response);

            return Ok(publisherModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]
        public IActionResult DeletePublisher(int id)
        {
            if (id == 0)
                return BadRequest("id is null");

            var response = _publisherRepository.DeletePublisher(id);
            return Ok(response);
        }
    }
}
