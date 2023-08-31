using Amazon.S3;
using Microsoft.AspNetCore.Mvc;

namespace AwsTestApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class BucketController : ControllerBase
    {
        [HttpGet("list")]
        public async Task<ActionResult> List()
        {
            var client = new AmazonS3Client("AKIAYTSKETIQA4H5KV7Y", "kcYsufSkFa6DgisWSvB33BlMwGANmTLG09Fk+cx5");
            var data = await client.ListBucketsAsync();
            var buckets = data.Buckets.Select(x=>x.BucketName).ToList();
            return Ok(buckets);  
        }
    }
}
