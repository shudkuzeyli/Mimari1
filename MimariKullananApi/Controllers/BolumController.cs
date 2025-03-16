using Microsoft.AspNetCore.Mvc;

namespace MimariKullananApi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class BolumController : ControllerBase
	{
	
		private readonly ILogger<BolumController> _logger;

		public BolumController(ILogger<BolumController> logger)
		{
			_logger = logger;
		}



	}
}
