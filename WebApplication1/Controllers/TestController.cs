using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        string getText(int to)
        {
            string resultf = "";
            if (to%3==0 && to%5==0)
            {
                resultf = "StarRez";
            }
            else if (to%3==0)
            {
                resultf = "Star";
            }
            else if (to%5==0)
            {
                resultf = "Rez";
            }
            else
            {
                resultf = to.ToString();
            }
            return resultf;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<TestClass> Get(int from, int to)
        {
            return Enumerable.Range(from, to - from + 1).Select(index => new TestClass
            {
                kidNumber = index,
                kidResponse = getText(index)
            })
            .ToArray();
        }

        [HttpPost()]
        public ResultfClass Collect(TestClass testClass)
        {
            ResultfClass resultfClass = new ResultfClass();
            resultfClass.isValid = (testClass.kidResponse == getText(testClass.kidNumber));
            resultfClass.expectedResponse = getText(testClass.kidNumber);
            return resultfClass;
        }
    }
}
